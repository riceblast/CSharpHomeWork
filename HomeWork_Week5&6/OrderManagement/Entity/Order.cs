using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Entity
{
	[Serializable]
	public class Order : IComparable<Order>
	{
		private int id; // 订单编号
		private DateTime dealTime; // 交易时间
		private string buyerName;   // 买家姓名
		private List<OrderItem> orderItems; // 所有订单详细信息

		public List<OrderItem> OrderItems
		{
			get { return orderItems; }
			set { orderItems = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string BuyerName
		{
			get { return buyerName; }
			set { buyerName = value; }
		}

		public DateTime DealTime
		{
			get { return dealTime; }
			set { dealTime = value; }
		}

		public double TotalPrice
		{
			get
			{
				double sum = 0;
				foreach (var orderItem in orderItems)
				{
					sum += orderItem.TotalPrice;
				}
				return sum;
			}

			set { }
		}

		// 构造函数
		public Order(int id, DateTime dealTime, string buyerName, List<OrderItem> orderItems = null)
		{
			this.id = id;
			this.dealTime = dealTime;
			this.buyerName = buyerName;
			this.orderItems = orderItems;
		}

		// 无参构造函数
		public Order():this(0,DateTime.Now,"null")
		{

		}

		public int CompareTo(Order other)
		{
			return this.id.CompareTo(other.Id);
		}

		public override bool Equals(object obj)
		{
			Order other = obj as Order;
			if (other == null)
				return false;

			// 如果订单id相同，则为相同订单
			if (this.id == other.Id && this.buyerName == other.buyerName &&
				this.orderItems.Equals(other.orderItems))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("订单编号: " + this.id + "\n");
			builder.Append("买家: " + this.buyerName + "\n");
			builder.Append("交易日期: " + this.dealTime + "\n");
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
