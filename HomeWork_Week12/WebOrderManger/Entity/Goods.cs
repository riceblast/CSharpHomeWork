using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithMysql.Entity
{
	[Serializable]
	public enum GoodsType
	{
		// 存放了所有商品
		Battery, // 电池
		Cmos, // cmos元件
		Screen, // 屏幕
		Soc, // 芯片
		NullGoods, // 用于指示商品错误的情况
	}

	public class PriceData
	{
		// 每种元件对应的价格变量
		private static double batteryPrice;
		private static double cmosPrice;
		private static double screenPrice;
		private static double socPrice;


		public static double BatteryPrice
		{
			get { return batteryPrice; }
			set { batteryPrice = value; }
		}

		public static double CmosPrice
		{
			get { return cmosPrice; }
			set { cmosPrice = value; }
		}

		public static double ScreenPrice
		{
			get { return screenPrice; }
			set { screenPrice = value; }
		}

		public static double SocPrice
		{
			get { return socPrice; }
			set { socPrice = value; }
		}

		public static double GetPrice(GoodsType goodsType)
		{
			switch (goodsType)
			{
				case GoodsType.Battery:
					return batteryPrice;
				case GoodsType.Cmos:
					return cmosPrice;
				case GoodsType.Screen:
					return screenPrice;
				case GoodsType.Soc:
					return socPrice;
				default:
					return 0;
			}
		}

		public static bool SetPrice(GoodsType goodsType, double newPrice)
		{
			switch (goodsType)
			{
				case GoodsType.Battery:
					batteryPrice = newPrice;
					return true;
				case GoodsType.Cmos:
					cmosPrice = newPrice;
					return true;
				case GoodsType.Screen:
					screenPrice = newPrice;
					return true;
				case GoodsType.Soc:
					socPrice = newPrice;
					return true;
				default:
					return false;
			}
		}

		// 静态构造体，将各种元器件的价格初始化
		static PriceData()
		{
			batteryPrice = 100;
			cmosPrice = 1000;
			screenPrice = 500;
			socPrice = 9999;
		}

	}
}
