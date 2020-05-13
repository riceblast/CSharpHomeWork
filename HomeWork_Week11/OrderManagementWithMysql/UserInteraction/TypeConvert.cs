using OrderManagementWithMysql.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithMysql.UserInteraction
{
    public class TypeConvert
    {
        public static void String2Enum(string goodsName, out GoodsType resultName)
        {
            string temp = goodsName.ToUpper();

            switch (temp)
            {
                case "BATTERY":
                    {
                        resultName = GoodsType.Battery;
                        break;
                    }
                case "CMOS":
                    {
                        resultName = GoodsType.Cmos;
                        break;
                    }
                case "SCREEN":
                    {
                        resultName = GoodsType.Screen;
                        break;
                    }
                case "SOC":
                    {
                        resultName = GoodsType.Soc;
                        break;
                    }
                default:
                    {
                        resultName = GoodsType.NullGoods;
                        break;
                    }
            }
        }

        public static string Enum2String(GoodsType goodsType)
        {
            switch (goodsType)
            {
                case GoodsType.Battery:
                    return "Battery";
                case GoodsType.Cmos:
                    return "Cmos";
                case GoodsType.Screen:
                    return "Cmos";
                case GoodsType.Soc:
                    return "Soc";
                default:
                    return string.Empty;
            }
        }
    }
}