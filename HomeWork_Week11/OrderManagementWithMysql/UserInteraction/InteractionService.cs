using OrderManagementWithMysql.ControlSystem;
using OrderManagementWithMysql.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithMysql.UserInteraction
{
    public class InteractionService
    {
        // 提示用户添加记录
        public static void Appeand(string buyerName)
        {
            // 变量声明
            int orderItemCount = 0;
            string goodsName; // 商品名称
            GoodsType goodsType; // 商品类型
            int goodsCount = 0; // 某种获取购买的数量
            List<OrderItem> orderItems = new List<OrderItem>(); // 用于存储新建的订单详细项


            while(orderItemCount <= 0)
            {
                // 获取订单详细项个数
                Console.Write("请输入当前订单的订单明细项的个数(输入的数字要求大于0)：");
                orderItemCount = Convert.ToInt32(Console.ReadLine());
            }

            // 根据详细订单数获取订单详细项
            for (int i = 0; i < orderItemCount; i++)
            {
                Console.Write("\n请输入购买的商品\n");
                Console.Write("商品类型：Battery, Cmos, Screen, Soc:\n");
                goodsName = Console.ReadLine();
                TypeConvert.String2Enum(goodsName, out goodsType);
                // 判断是否输入了库存中存在的商品
                if (goodsType == GoodsType.NullGoods)
                {
                    Console.WriteLine($"不存在名为{goodsName}的商品，请重新输入");
                    i--;
                    continue;
                }

                goodsCount = 0;
                // 如果存在该种商品，则提示用户输入购买的商品数量
                while(goodsCount <= 0)
                {
                    // 提示用户输入大于0的商品数量
                    Console.Write($"请输入购买{goodsName}的数量(要求输入的数字大于0)：");
                    goodsCount = Convert.ToInt32(Console.ReadLine());

                }

                // 根据捕获的数据新建订单明细项
                orderItems.Add(new OrderItem(goodsType, goodsCount));
            }

            // 所有的商品及购买数量输入完成后，将项OrderService中添加新订单
            OrderService.AppendOrder(buyerName, orderItems);
            Console.WriteLine($"添加订单成功");
        }

        // 提示用户删除
        public static void Delete()
        {
            // 根据订单号来进行删除订单
            // 变量声明
            int orderId = 0; // 订单id

            // 提示用户通过命令行输入订单号
            while(orderId <= 0)
            {
                // 如果用户输入的数据不规范，则一直输入
                Console.Write("请输入需要删除的订单号(要求输入正整数)：");
                orderId = Convert.ToInt32(Console.ReadLine());
            }

            // 调用OrderService删除订单
            if (OrderService.DeleteOrder(orderId))
            {
                Console.WriteLine($"删除订单{orderId}成功");
            }
            else
            {
                Console.WriteLine($"删除订单{orderId}失败");
            }
        }

        // 提示用户修改
        public static void Update()
        {
            // 变量声明
            int updateMode = 0; // 决定需要修改的模式
            int orderId = 0; // 需更新的订单号
            string buyerName = null; // 买家姓名
            int orderItemCount = 0;
            string goodsName; // 商品名称
            GoodsType goodsType; // 商品类型
            int goodsCount = 0; // 某种获取购买的数量
            List<OrderItem> orderItems = new List<OrderItem>(); // 用来存储待改的订单明细项

            // 提示用户输入需要更改的订单号
            while (orderId <= 0)
            {
                // 如果用户输入的数据不规范，则一直输入
                Console.Write("请输入需要修改的订单号(要求输入正整数)：");
                orderId = Convert.ToInt32(Console.ReadLine());
            }

            // 询问用户需要更新什么信息
            while (updateMode != 1 && updateMode != 2)
            {
                Console.Write("请选择需要更新的数据(买家信息请输入1，订单详细项请输入2)：");
                updateMode = Convert.ToInt32(Console.ReadLine());
            }

                if (updateMode == 1)
                {
                    // 如果用户需要更改买家的信息
                    Console.Write("请输入需要正确的买家信息：");
                    buyerName = Console.ReadLine();
                    OrderService.UpdateOrder(orderId, buyerName);
                    Console.WriteLine("订单修改成功");
                }
                else
                {
                    // 如果需要修改订单明细项
                    while (orderItemCount <= 0)
                    {
                        // 获取订单详细项个数
                        Console.Write("请输入当前订单的订单明细项的个数(输入的数字要求大于0)：");
                        orderItemCount = Convert.ToInt32(Console.ReadLine());
                    }

                    // 根据详细订单数获取订单详细项
                    for (int i = 0; i < orderItemCount; i++)
                    {
                        Console.Write("请输入购买的商品\n");
                        Console.Write("商品类型：Battery, Cmos, Screen, Soc\n");
                        goodsName = Console.ReadLine();
                        TypeConvert.String2Enum(goodsName, out goodsType);
                        // 判断是否输入了库存中存在的商品
                        if (goodsType == GoodsType.NullGoods)
                        {
                            Console.WriteLine($"不存在名为{goodsName}的商品，请重新输入");
                            i--;
                            continue;
                        }

                    goodsCount = 0;
                        // 如果存在该种商品，则提示用户输入购买的商品数量
                        while (goodsCount <= 0)
                        {
                            // 提示用户输入大于0的商品数量
                            Console.Write($"请输入购买{goodsName}的数量(要求输入的数字大于0)：");
                            goodsCount = Convert.ToInt32(Console.ReadLine());
                        }

                        // 根据捕获的数据新建订单明细项
                        orderItems.Add(new OrderItem(goodsType, goodsCount));
                    }

                    // 更改订单明细项
                    OrderService.UpdateOrder(orderId, orderItems);
                }
        }

        // 提示用户查询记录
        public static void Query()
        {
            // 变量声明
            int queryMode = 0; // 标识查询的模式
            int orderId = 0; // 查询订单号
            string goodsName;
            GoodsType goodsType = GoodsType.NullGoods;
            string buyerName;
            List <Order> orders = new List<Order>(); // 用于接收查询结果

            // 获取查询的模式
            // 询问用户需要更新什么信息
            while (queryMode != 1 && queryMode != 2 && queryMode != 3)
            {
                Console.Write("请选择需要查询订单的模式(通过订单号查询请输入1，通过商品名称查询请输入2，通过客户查询请输入3)：");
                queryMode = Convert.ToInt32(Console.ReadLine());
            }

            if (queryMode == 1)
            {
                // 输入要查询的订单号
                while (orderId <= 0)
                {
                    // 如果用户输入的数据不规范，则一直输入
                    Console.Write("请输入需要查询的订单号(要求输入正整数)：");
                    orderId = Convert.ToInt32(Console.ReadLine());
                }

                orders = OrderService.QueryOrder(orderId);
            }
            else if (queryMode == 2)
            {
                // 通过名称查询
                while(goodsType == GoodsType.NullGoods)
                {
                    Console.Write("请输入购买的商品\n");
                    Console.WriteLine("商品类型：Battery, Cmos, Screen, Soc");
                    goodsName = Console.ReadLine();
                    TypeConvert.String2Enum(goodsName, out goodsType);
                    // 判断是否输入了库存中存在的商品
                    if (goodsType == GoodsType.NullGoods)
                    {
                        Console.WriteLine($"不存在名为{goodsName}的商品，请重新输入");
                    }
                }

                // 查询
                orders = OrderService.QueryOrder(goodsType);
            }
            else
            {
                // 通过买家信息查询
                Console.Write("请输入需要查询的买家信息：");
                buyerName = Console.ReadLine();

                // 查询
                orders = OrderService.QueryOrder(buyerName);
            }

            if(orders.Count == 0)
            {
                Console.WriteLine("订单查询错误，不存在该订单");
            }
            else
            {
                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                }
            }

        }

        //// 将订单写成xml文件
        //public static void Export()
        //{
        //    OrderService.Export();
        //}

        //// 导出xml文件
        //public static void Import()
        //{
        //    OrderService.Import();
        //}
    }
}
