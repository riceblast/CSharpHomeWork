using OrderManagementWithMysql.ControlSystem;
using OrderManagementWithMysql.Entity;
using OrderManagementWithMysql.UserInteraction;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManagementWithMysql.ControlSystem
{
	public class OrderService
	{
		// 存储着订单列表
		//private static List<Order> orders;
		//private static int totalOrderNums; // 用于计算订单的编号，从1开始，依次累加

		//// 静态构造器，用于初始化订单和订单编号
		//static OrderService()
		//{
		//	orders = new List<Order>();
		//	totalOrderNums = 0;
		//}

		//// 用于外界获取订单编号
		//public static int TotalOrderNums
		//{
		//	get { return totalOrderNums; }
		//	set { totalOrderNums = value; }
		//}

		//// 用于序列化和反序列化
		//private static List<Order> Orders
		//{
		//	get
		//	{
		//		using (ManagerContext managerContext = new ManagerContext())
		//		{
		//			var allOrders = managerContext.Orders.Where(order => true);
		//			return allOrders.ToList();
		//		}
		//	}
		//}

		// 增加订单
		public static bool AppendOrder(string buyerName, List<OrderItem> orderItems)
		{
			// 确保所添加的订单和订单明细项不会重复
			using (ManagerContext managerContext = new ManagerContext())
			{
				Order newOrder = new Order(DateTime.Now, buyerName, orderItems);
				managerContext.Orders.Add(newOrder);
				managerContext.SaveChanges();
			}
			return true;

			//for(int i = 0; i < orderItems.Count; i++)
			//{
			//	for(int j = i + 1; j < orderItems.Count; j++)
			//	{
			//		if (orderItems[i].Equals(orderItems[j]))
			//		{
			//			throw new ApplicationException("不能添加重复的订单明细");
			//		}
			//	}
			//}

			//// 如果订单无重复，则将订单添加到List中
			//totalOrderNums++; // 此时totalOrderNums为当前Order的订单id，从1开始
			//Order newOrder = new Order(DateTime.Now, buyerName, orderItems); // 新建订单对象
			//orders.Add(newOrder); // 添加完成
			//return true;
		}

		// 删除订单,可以删除某个订单编号的订单
		public static bool DeleteOrder(int id)
		{
			using (ManagerContext managerContext = new ManagerContext())
			{
				// 查找订单号为id的订单
				var deletingOrder = managerContext.Orders.Include("OrderItems").First(o => o.Id == id);
				if(deletingOrder != null)
				{
					managerContext.Orders.Remove(deletingOrder);
					managerContext.SaveChanges();
					return true;
				}
				else
				{
					throw new Exception($"不存在订单号为{id}的订单，删除错误");
				}

			}

			//// 变量声明
			//bool isDelete = false;

			//// 删除订单号为id的订单
			//for(int i = 0; i < orders.Count; i++)
			//{
			//	// 如果找到了订单号为id的订单则将其删除
			//	if(orders[i].Id == id)
			//	{
			//		orders.RemoveAt(i);
			//		isDelete = true;
			//		break;
			//	}
			//}

			//// 如果未成功删除，则抛出异常告知用户
			//if (!isDelete)
			//{
			//	throw new ApplicationException($"不存在订单号为{id}的订单，删除错误");
			//}

			//// 删除成功
			//return true;
		}
	
		// 修改订单,修改订单明细项
		public static bool UpdateOrder(int id, List<OrderItem> orderItems)
		{
			using (ManagerContext managerContext = new ManagerContext())
			{
				// 查找订单号为id的订单
				// 不可以直接进行赋值，可能原因推断：参数的orderItems来自managerContext外部；所以主键和外键都不同步，最好的方法就是先删后加
				Order updatingOrder = managerContext.Orders.Include(o => o.OrderItems).FirstOrDefault(order => order.Id == id);
				int foreignKey = updatingOrder.OrderItems[0].OrderId;
				if (updatingOrder != null)
				{
					// 先将原有记录删除
					while (true)
					{
						var targetOrderItem = managerContext.OrderItems.FirstOrDefault(orderItem => orderItem.OrderId == foreignKey);
						if(targetOrderItem != null)
						{
							managerContext.OrderItems.Remove(targetOrderItem);
							managerContext.SaveChanges();
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
						managerContext.Entry(newOrderItem).State = EntityState.Added;
						managerContext.SaveChanges();
					}
					return true;
				}
				else
				{
					throw new Exception($"不存在订单号为{id}的订单，修改错误");
				}
			}


			//// 变量声明
			//bool isUpdate = false;

			//// 删除订单号为id的订单
			//for (int i = 0; i < orders.Count; i++)
			//{
			//	// 如果找到了订单号为id的订单则将其删除
			//	if (orders[i].Id == id)
			//	{
			//		orders[i].OrderItems = orderItems;
			//		isUpdate = true;
			//		break;
			//	}
			//}

			//// 如果未成功删除，则抛出异常告知用户
			//if (!isUpdate)
			//{
			//	throw new ApplicationException($"不存在订单号为{id}的订单，修改错误");
			//}

			//// 修改成功
			//return true;
		}
	
		// 修改订单，修改订单的交易人员信息
		public static bool UpdateOrder(int id, string buyerName)
		{
			// 查找订单号为id的订单
			using (ManagerContext managerContext = new ManagerContext())
			{
				Order updatingOrder = managerContext.Orders.Include("OrderItems").FirstOrDefault(order => order.Id == id);
				if(updatingOrder != null)
				{
					// 查找成功
					updatingOrder.BuyerName = buyerName;
					managerContext.SaveChanges();
					return true;
				}
				else
				{
					throw new ApplicationException($"不存在订单号为{id}的订单，修改错误");
				}
			}

			//// 变量声明
			//bool isUpdate = false;

			//// 删除订单号为id的订单
			//for (int i = 0; i < orders.Count; i++)
			//{
			//	// 如果找到了订单号为id的订单则将其删除
			//	if (orders[i].Id == id)
			//	{
			//		orders[i].BuyerName = buyerName;
			//		isUpdate = true;
			//		break;
			//	}
			//}

			//// 如果未成功删除，则抛出异常告知用户
			//if (!isUpdate)
			//{
			//	throw new ApplicationException($"不存在订单号为{id}的订单，修改错误");
			//}

			//// 修改成功
			//return true;
		}

		//查询订单，以订单号查询
		public static List<Order> QueryOrder(int id)
		{
			using(ManagerContext managerContext = new ManagerContext()){
				var targerOrders = managerContext.Orders.Include("OrderItems").Where(order => order.Id == id);
				return targerOrders.ToList();
			}

			//var resultOrder = from order in orders
			//					where (order.Id == id)
			//					select order;

			//return resultOrder.OrderBy(order => order.TotalPrice).ToList();
		}

		//查询订单，以商品名称查询
		public static List<Order> QueryOrder(GoodsType goodsType)
		{
			// 为何需要使用AsEnumerable
			// 以下解答来自stackOverflow
			// Is managerContext.Orders a Linq-To-SQL database context? In which case, 
			// you can only use simple expressions to the right of the => operator. 
			// The reason is, these expressions are not executed, 
			// but are converted to SQL to be executed against the database. 
			using (ManagerContext managerContext = new ManagerContext())
			{
				var targetOrders = managerContext.Orders.Include(o => o.OrderItems).AsEnumerable().Where(order =>
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
			}

			//var resultOrder = orders.Where(o =>
			//{
			//	foreach (var orderItem in o.OrderItems)
			//	{
			//		if (orderItem.GoodsName == goodsType)
			//			return true;
			//	}
			//	return false;
			//});

			//return resultOrder.OrderBy(order => order.TotalPrice).ToList();
		}

		//查询订单，以客户查询
		public static List<Order> QueryOrder(string buyerName)
		{
			using (ManagerContext managerContext = new ManagerContext())
			{
				var targetContext = managerContext.Orders.Include(o => o.OrderItems).Where(order => order.BuyerName == buyerName);
				return targetContext.ToList();
			}

			//var resultOrder = from o in orders
			//				  where o.BuyerName == buyerName
			//				  select o;
			//return resultOrder.OrderBy(order => order.TotalPrice).ToList();
		}

		//// 对订单按照订单号进行排序
		//public static void sortOrders()
		//{
		//	orders.Sort();
		//}

		//// 将订单导出为xml文件
		//public static void Export()
		//{
		//	Console.WriteLine("开始序列化");
		//	XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>)); // 序列化器
		//	using (FileStream fs = new FileStream("orderList.xml", FileMode.Create))
		//	{
		//		xmlSerializer.Serialize(fs, Orders);
		//	}
		//	Console.WriteLine("序列化成功");
		//	Console.WriteLine(File.ReadAllText("orderList.xml"));
		//}

		//// 将xml文件还原为订单
		//public static void Import()
		//{
		//	// 建立xml序列化对象
		//	XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
		//	using (FileStream fileStream = new FileStream("orderList.xml", FileMode.Open))
		//	{
		//		Console.WriteLine("开始序列化");
		//		Orders = xmlSerializer.Deserialize(fileStream) as List<Order>;
		//	}
		//	Console.WriteLine("序列化成功");
		//	foreach(Order o in orders)
		//	{
		//		Console.WriteLine(o);
		//	}
		//}
	}
}
