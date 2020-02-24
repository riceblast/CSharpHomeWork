using System;

namespace ConsoleAppCaculator {
    class Program {
        static void Main(string[] args) {
            int num1 = 0, num2 = 0;
            bool reWrite = false;
            double? result = null;
            string myOperator,op1,op2;


            while (true) {
                if (reWrite)
                    Console.WriteLine("\nPlease enter the num again with the correct form");
                Console.Write("first num:");//第一个操作数
                op1 = Console.ReadLine();
                if (!Int32.TryParse(op1, out num1)) {
                    reWrite = true;
                    continue;
                }

                Console.Write("second num:");//第二个操作数
                op2 = Console.ReadLine();
                if (!Int32.TryParse(op2, out num2)) {
                    reWrite = true;
                    continue;
                }

                reWrite = false;

                Console.Write("operator:"); //操作符
                myOperator = Console.ReadLine();
                switch (myOperator) {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = ((double)num1) / num2;
                        else {
                            Console.WriteLine("不能除0\n");
                            continue;
                        }
                        break;
                    default: {
                            Console.WriteLine("无效运算符\n");
                            continue;
                            break;
                        }
                    
                }

                if (result != null)
                    Console.WriteLine($"result:{result}\n");

            }

        }
    }
}
