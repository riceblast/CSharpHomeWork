using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNum {
    class Program {
        static void Main(string[] args) {
            Prime(100);
        }

        public static void Prime(int upperLimit) {//upperLimit表示这个数组的上限，求上限以内的素数
            //用一个数组来装所有小于upperlimit大于2的数
            bool[] list = new bool[upperLimit + 1];//下标即代表数字，从0到upperLimit
            for (int i = 2; i < list.Length; i++)
                list[i] = true;//将数组所有元素初始化为true
            list[0] = list[1] = false;//0和1将不会被输出

            //去除倍数
            for(int num = 0; num * num <= upperLimit; num++) 
                for(int Mul = 1; num * Mul <= upperLimit; Mul++) 
                    list[Mul * num] = false;

            for (int i = 0; i < list.Length; i++) {
                if (list[i])
                    Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }
    }
}
