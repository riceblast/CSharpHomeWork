using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Entity
{
	[Serializable]
	public class OrderItem
	{
		private GoodsType goodsName; // 商品名称
		private double unitPrice; // 单价
		private int goodsNum; // 商品数量
		private double totalPrice; // 商品总价

		public double UnitPirce
		{
			get { return unitPrice; }
			set { unitPrice = value; }
		}

		public int GoodsNum
		{
			get { return goodsNum; }
			set { goodsNum = value; }
		}

		// 商品总价
		public double TotalPrice
		{
			
			get { return totalPrice; }
			set { totalPrice = value; }
		}

		public GoodsType GoodsName
		{
			get { return goodsName; }
			set { goodsName = value; }
		}

		// 构造函数
		public OrderItem(GoodsType goodsName,int goodsNum)
		{
			this.goodsName = goodsName;
			this.unitPrice = PriceData.GetPrice(goodsName);
			this.goodsNum = goodsNum;
			totalPrice = unitPrice * goodsNum;
		}

		// 无参构造函数
		public OrderItem() : this(GoodsType.NullGoods, -1)
		{
			totalPrice = 0;
		}
		
		public override bool Equals(object obj)
		{
			OrderItem other = obj as OrderItem;
			if (other == null)
				return false;

			// 如果商品名和商品数量均相等，则认为是相同订单
			if (this.goodsName == other.GoodsName && this.goodsNum == other.GoodsNum)
				return true;
			else
				return false;
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder("商品名称: ");
			builder.Append(goodsName.ToString() + "  ");
			builder.Append("单价: ");
			builder.Append(unitPrice.ToString() + "  ");
			builder.Append("数量: ");
			builder.Append(goodsNum.ToString() + "  ");
			builder.Append("总价: ");
			builder.Append(TotalPrice.ToString() + "\n");
			return builder.ToString();
		}
	}

}
