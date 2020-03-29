using OrderManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManagement.ControlSystem
{
	class OrderService
	{
		// 存储着订单列表
		private static List<Order> orders;
		private static int totalOrderNums; // 用于计算订单的编号，从1开始，依次累加

		// 静态构造器，用于初始化订单和订单编号
		static OrderService()
		{
			orders = new List<Order>();
			totalOrderNums = 0;
		}

		// 用于外界获取订单编号(只读)
		public static int TotalOrderNums
		{
			get { return totalOrderNums; }
		}

		// 用于外界获取订单
		public static List<Order> Orders
		{
			get { return orders; }
			set { orders = value; }
		}

		// 增加订单
		public static bool AppendOrder(string buyerName, List<OrderItem> orderItems)
		{
			// 确保所添加的订单和订单明细项不会重复
			// 由于订单的重复是由订单编号确定的，故订单不会重复
			// 现在判断订单明细项是否重复
			for(int i = 0; i < orderItems.Count; i++)
			{
				for(int j = i + 1; j < orderItems.Count; j++)
				{
					if (orderItems[i].Equals(orderItems[j]))
					{
						throw new Exception("不能添加重复的订单明细");
					}
				}
			}

			// 如果订单无重复，则将订单添加到List中
			totalOrderNums++; // 此时totalOrderNums为当前Order的订单id，从1开始
			Order newOrder = new Order(totalOrderNums, DateTime.Now, buyerName, orderItems); // 新建订单对象
			orders.Add(newOrder); // 添加完成
			return true;
		}

		// 删除订单,可以删除某个订单编号的订单
		public static bool DeleteOrder(int id)
		{
			// 变量声明
			bool isDelete = false;

			// 删除订单号为id的订单
			for(int i = 0; i < orders.Count; i++)
			{
				// 如果找到了订单号为id的订单则将其删除
				if(orders[i].Id == id)
				{
					orders.RemoveAt(i);
					isDelete = true;
					break;
				}
			}

			// 如果未成功删除，则抛出异常告知用户
			if (!isDelete)
			{
				throw new Exception($"不存在订单号为{id}的订单，删除错误");
			}

			// 删除成功
			return true;
		}
	
		// 修改订单,修改订单明细项
		public static bool UpdateOrder(int id, List<OrderItem> orderItems)
		{
			// 变量声明
			bool isUpdate = false;

			// 删除订单号为id的订单
			for (int i = 0; i < orders.Count; i++)
			{
				// 如果找到了订单号为id的订单则将其删除
				if (orders[i].Id == id)
				{
					orders[i].OrderItems = orderItems;
					isUpdate = true;
					break;
				}
			}

			// 如果未成功删除，则抛出异常告知用户
			if (!isUpdate)
			{
				throw new Exception($"不存在订单号为{id}的订单，修改错误");
			}

			// 修改成功
			return true;
		}
	
		// 修改订单，修改订单的交易人员信息
		public static bool UpdateOrder(int id, string buyerName)
		{
			// 变量声明
			bool isUpdate = false;

			// 删除订单号为id的订单
			for (int i = 0; i < orders.Count; i++)
			{
				// 如果找到了订单号为id的订单则将其删除
				if (orders[i].Id == id)
				{
					orders[i].BuyerName = buyerName;
					isUpdate = true;
					break;
				}
			}

			// 如果未成功删除，则抛出异常告知用户
			if (!isUpdate)
			{
				throw new Exception($"不存在订单号为{id}的订单，修改错误");
			}

			// 修改成功
			return true;
		}

		//查询订单，以订单号查询
		public static List<Order> QueryOrder(int id)
		{
			var resultOrder = from order in orders
								where (order.Id == id)
								select order;

			return resultOrder.OrderBy(order => order.TotalPrice).ToList();
		}

		//查询订单，以商品名称查询
		public static List<Order> QueryOrder(GoodsType goodsType)
		{
			var resultOrder = orders.Where(o =>
			{
				foreach (var orderItem in o.OrderItems)
				{
					if (orderItem.GoodsName == goodsType)
						return true;
				}
				return false;
			});

			return resultOrder.OrderBy(order => order.TotalPrice).ToList();
		}

		//查询订单，以客户查询
		public static List<Order> QueryOrder(string buyerName)
		{
			var resultOrder = from o in orders
							  where o.BuyerName == buyerName
							  select o;
			return resultOrder.OrderBy(order => order.TotalPrice).ToList();
		}

		// 对订单按照订单号进行排序
		public void sortOrders()
		{
			orders.Sort();
		}

		// 将订单导出为xml文件
		public static void Expert()
		{
			Console.WriteLine("开始序列化");
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>)); // 序列化器
		}
	}
}
