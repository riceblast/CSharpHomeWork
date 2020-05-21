using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithMysql.Entity
{
	[Serializable]
	public class Order
	{
		//static Order()
		//{
		//	Order.OrderCount = 0;
		//}

		//private static int OrderCount; // 总共的订单数量
		//private int id; // 订单编号
		//private DateTime dealTime; // 交易时间
		//private string buyerName;   // 买家姓名
		//private List<OrderItem> orderItems; // 所有订单详细信息

		public  List<OrderItem> OrderItems
		{
			get;
			set;
		}

		[Key]
		[Column("OrderID")]
		public int Id
		{
			// 主键必须set和get都有
			get;
			set;
		}

		public string BuyerName
		{
			get;
			set;
		}

		public DateTime DealTime
		{
			get;
			set;
		}

		public double TotalPrice
		{
			//get
			//{
			//	double sum = 0;
			//	foreach (var orderItem in this.OrderItems)
			//	{
			//		sum += orderItem.TotalPrice;
			//	}
			//	return sum;
			//}
			get;

			set;
		}

		// 构造函数
		public Order(DateTime dealTime, string buyerName, List<OrderItem> orderItems)
		{
			//Order.OrderCount++;
			//this.id = Order.OrderCount;
			//this.dealTime = dealTime;
			//this.buyerName = buyerName;
			this.DealTime = dealTime;
			this.BuyerName = buyerName;
			this.OrderItems = orderItems;

			foreach (var orderItem in this.OrderItems)
			{
				this.TotalPrice += orderItem.TotalPrice;
			}
		}

		// 无参构造函数
		public Order() 
		{
			this.DealTime = DateTime.Now;
			this.BuyerName = "null";
			this.OrderItems = new List<OrderItem>();
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("订单编号: " + this.Id + "\n");
			builder.Append("买家: " + this.BuyerName + "\n");
			builder.Append("交易日期: " + this.DealTime + "\n");
			builder.Append("----------------------------------\n");
			foreach (var orderItem in OrderItems)
			{
				builder.Append(orderItem);
			}
			builder.Append("总金额: " + this.TotalPrice + "\n");
			return builder.ToString();
		}


	}

}
