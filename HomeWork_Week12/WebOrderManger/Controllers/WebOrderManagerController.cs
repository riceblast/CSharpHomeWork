using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderManagementWithMysql.ControlSystem;
using OrderManagementWithMysql.Entity;
using Microsoft.EntityFrameworkCore;
using OrderManagementWithMysql.UserInteraction;
using Microsoft.Extensions.Logging;

namespace WebOrderManger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderServiceController : ControllerBase
    {

        private readonly ManagerContext managerDb;

		public OrderServiceController(ManagerContext managerDb)
		{
			this.managerDb = managerDb;
		}

		// 增加订单
		// api/OrderService
		[HttpPost]
		public ActionResult<Order> AppendOrder(Order newOrder)
		{
			if(newOrder == null){
				return BadRequest("参数无效");
			}
			newOrder.DealTime = DateTime.Now;
			// 确保所添加的订单和订单明细项不会重复
			try{
				this.managerDb.Orders.Add(newOrder);
				this.managerDb.SaveChanges();
			}
			catch(Exception e){
				return BadRequest(e.Data); 
			}

			return newOrder;

		}

		// 删除订单,可以删除某个订单编号的订单
		// api/OrderService/{id}
		[HttpDelete("{id}")]
		public ActionResult<Order> DeleteOrder(int id)
		{

			// 查找订单号为id的订单、
			try{
			var deletingOrder = managerDb.Orders.Include("OrderItems").First(o => o.Id == id);
			if(deletingOrder != null)
			{
				managerDb.Orders.Remove(deletingOrder);
				managerDb.SaveChanges();
			}
			else
			{
				return NotFound($"不存在订单号为{id}的订单，删除错误");
			}
			}
			catch(Exception e){
				return BadRequest(e.Data);
			}

			return NoContent();
		}
		
		// 修改订单，修改订单的交易人员信息
		// api/OrderService/buyerName/{id}
		[HttpPut("buyerName/{id}")]
		public ActionResult<Order> UpdateOrder(int id, string buyerName)
		{
			// 查找订单号为id的订单
				Order updatingOrder = managerDb.Orders.Include("OrderItems").FirstOrDefault(order => order.Id == id);
				try{
				if(updatingOrder != null)
				{
					// 查找成功
					updatingOrder.BuyerName = buyerName;
					managerDb.SaveChanges();
					return updatingOrder;
				}
				else
				{
					return NotFound($"不存在订单号为{id}的订单，修改错误");
				}
				}catch(Exception e){
					return BadRequest(e.Data);
				}
		}
	
		// 修改订单,修改订单明细项
		// api/OrderService/orderItems/{id}
		[HttpPut("orderItems/{id}")]
		public ActionResult<Order> UpdateOrder(List<OrderItem> orderItems,int id)
		{

			// 查找订单号为id的订单
			// 不可以直接进行赋值，可能原因推断：参数的orderItems来自managerContext外部；所以主键和外键都不同步，最好的方法就是先删后加
			Order updatingOrder = managerDb.Orders.Include(o => o.OrderItems).FirstOrDefault(order => order.Id == id);
			try{
			int foreignKey = updatingOrder.OrderItems[0].OrderId;
			if (updatingOrder != null)
			{
					// 先将原有记录删除
				while (true)
				{
					var targetOrderItem = managerDb.OrderItems.FirstOrDefault(orderItem => orderItem.OrderId == foreignKey);
					if(targetOrderItem != null)
					{
						managerDb.OrderItems.Remove(targetOrderItem);
						managerDb.SaveChanges();
					}
					else
					{
						break;
					}
				}

				// 再进行记录添加
				GoodsType goodsType;
				for (int i = 0; i < orderItems.Count; i++)
				{
					TypeConvert.String2Enum(orderItems[i].GoodsName, out goodsType);
					var newOrderItem = new OrderItem(goodsType, orderItems[i].GoodsNum);
					newOrderItem.OrderId = foreignKey;
					managerDb.Entry(newOrderItem).State = EntityState.Added;
					managerDb.SaveChanges();
				}
			}
			else
			{
				return NotFound($"不存在订单号为{id}的订单，修改错误");
			}
			}catch(Exception e){
				return BadRequest(e.Data);
			}
			return NoContent();
		}



		//查询订单，以订单号查询
		// api/OrderService/id/{id}
		[HttpGet("id/{id}")]
		public ActionResult<List<Order>> QueryOrder(int? id)
		{
			if(id == null){
				return managerDb.Orders.ToList();
			}

			try{
			var targerOrders = managerDb.Orders.Include("OrderItems").Where(order => order.Id == id);
			return targerOrders.ToList();
			}catch(Exception e){
				return BadRequest(e.Data);
			}

		}

		//查询订单，以商品名称查询
		// api/OrderService/goodsType/{goodsType}
		[HttpGet("goodsType/{goodsType}")]
		public ActionResult<List<Order>> QueryOrder(GoodsType goodsType)
		{
			// 为何需要使用AsEnumerable
			// 以下解答来自stackOverflow
			// Is managerContext.Orders a Linq-To-SQL database context? In which case, 
			// you can only use simple expressions to the right of the => operator. 
			// The reason is, these expressions are not executed, 
			// but are converted to SQL to be executed against the database. 
			try
			{
				var targetOrders = managerDb.Orders.Include(o => o.OrderItems).AsEnumerable().Where(order =>
				{
					foreach (var orderItem in order.OrderItems)
					{
						if (orderItem.GoodsName == TypeConvert.Enum2String(goodsType))
						{
							return true;
						}
					}
					return false;
				});

				return targetOrders.ToList();
			}catch(Exception e){
				return BadRequest(e.Data);
			}
		}

		//查询订单，以客户查询
		// api/OrderService/{buyerName}
		[HttpGet("buyerName/{buyerName}")]
		public ActionResult<List<Order>> QueryOrder(string buyerName)
		{
			try
			{
				var targetContext = managerDb.Orders.Include(o => o.OrderItems).Where(order => order.BuyerName == buyerName);
				return targetContext.ToList();
			}catch(Exception e){
				return BadRequest(e.Data);
			}
		}


    }
}
