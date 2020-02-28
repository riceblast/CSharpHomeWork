using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPrimeNumber {
    class Program {
        static void Main(string[] args) {

            int input = getInput();//获取输入
            //输出所有质因数
            Console.Write("所有质因数为：");
            foreach(int num in getPrimeFactor(input)) {
                Console.Write(num + " ");
            }
            Console.ReadLine();//防止命令行运行完就退出

        }

        public static int getInput() {//获取用户输入
            while (true) {
                try {
                    int input;//用于接收用户输入
                    Console.Write("输入一个数字:");
                    input = int.Parse(Console.ReadLine());
                    if (input > 1)
                        return input;
                    else
                        Console.WriteLine("请输入大于一的正整数");
                }
                catch (FormatException ex) {
                    Console.WriteLine("输入格式不正确");
                }
            }
        }

        public static bool IsPrime(int num) {//判断一个数是否是素数
            //用于判断素数
            for (int i = 2; i <= num / 2; i++) {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static List<int> getPrimeFactor(int num) {//获取一个数的所有质因数
            List<int> list = new List<int>();
            List<int> factors = new List<int>();
            //找到该数据的所有大于1的因数
            for (int i = 2; i <= num / 2; i++)
                if ((num % i) == 0)
                    list.Add(i);

            //找到所有质因数
            foreach (int n in list) {
                if (IsPrime(n))
                    factors.Add(n);
            }

            return factors;
        }
    }
}
