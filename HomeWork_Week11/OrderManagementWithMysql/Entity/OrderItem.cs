using OrderManagementWithMysql.UserInteraction;
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
	public class OrderItem
	{
		//static OrderItem()
		//{
		//	OrderItem.orderItemCount = 0;
		//}

		//private static int orderItemCount; // 记录orderItem的数量，用于给出orderItemId
		//private int id; // orderItem唯一标识符
		private GoodsType goodsName; // 商品名称
		//private double unitPrice; // 单价
		//private int goodsNum; // 商品数量
		//private double totalPrice; // 商品总价

		[Key]
		[Column("OrderItemID")]
		public int OrderItemId
		{
			get;
			set;
		}

		public double UnitPirce
		{
			get;
			set;
		}

		public int GoodsNum
		{
			get;
			set;
		}

		// 商品总价
		[Column("OrderItemTotalPrice")]
		public double TotalPrice
		{
			get;
			set;
		}

		public string GoodsName
		{
			get { return TypeConvert.Enum2String(goodsName); }
			set { TypeConvert.String2Enum(value, out this.goodsName); }
		}

		// 自动指向Order的外键
		[ForeignKey("")]
		public int OrderId { get; set; }

		// 构造函数
		public OrderItem(GoodsType goodsName,int goodsNum)
		{
			//OrderItem.orderItemCount++;
			//this.id = OrderItem.orderItemCount;

			this.goodsName = goodsName;
			this.UnitPirce = PriceData.GetPrice(goodsName);
			this.GoodsNum = goodsNum;
			this.TotalPrice = this.UnitPirce * goodsNum;
		}

		// 无参构造函数
		public OrderItem() : this(GoodsType.NullGoods, -1)
		{
			this.TotalPrice = 0;
		}
		
		//public override bool Equals(object obj)
		//{
		//	OrderItem other = obj as OrderItem;
		//	if (other == null)
		//		return false;

		//	// 如果商品名和商品数量均相等，则认为是相同订单
		//	if (this.GoodsName == other.GoodsName && this.GoodsNum == other.GoodsNum)
		//		return true;
		//	else
		//		return false;
		//}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder("商品名称: ");
			builder.Append(goodsName.ToString() + "  ");
			builder.Append("单价: ");
			builder.Append(this.UnitPirce.ToString() + "  ");
			builder.Append("数量: ");
			builder.Append(this.GoodsNum.ToString() + "  ");
			builder.Append("总价: ");
			builder.Append(TotalPrice.ToString() + "\n");
			return builder.ToString();
		}
	}

}
