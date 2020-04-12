using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Entity;
using OrderManagement.UserInteraction;

namespace OrderManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 声明：该订单系统在书写时做了如下假设：假设商品类型确定（4种），同时价格也确定
            // 变量声明
            string buyerName;
            int operateMode = 0; // 操作的类型

            Console.Write("请输入用户姓名：");
            buyerName = Console.ReadLine();
            while (true)
            {
                try
                {

                    // 提示

                    Console.WriteLine("\n请输入需要执行的操作");
                    Console.WriteLine("增加订单输入1，删除订单输入2，修改订单输入3，查询订单输入4，将订单序列化输入5，反序列化输入6");
                    operateMode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (operateMode)
                    {
                        case 1:
                            InteractionService.Appeand(buyerName);
                            Console.WriteLine();
                            break;
                        case 2:
                            InteractionService.Delete();
                            Console.WriteLine();
                            break;
                        case 3:
                            InteractionService.Update();
                            Console.WriteLine();
                            break;
                        case 4:
                            InteractionService.Query();
                            Console.WriteLine();
                            break;
                        case 5:
                            InteractionService.Export();
                            Console.WriteLine();
                            break;
                        case 6:
                            InteractionService.Import();
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("操作输入错误");
                            break;

                    }

                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
