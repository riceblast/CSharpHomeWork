using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperateOnArray {
    class Program {
        static void Main(string[] args) {
            int[] list = new int[] { 45, 33, 75, 37, 21, 88, 2354, -322, 0, 234 };
            double max, min, average, sum;
            Calculate(list,out max,out min,out average,out sum);
            Console.WriteLine($"max:{max}, min:{min}, average:{average}, sum:{sum}");
            Console.ReadLine();
        }

        static void Calculate(int[] list,out double max,out double min,out double average,out double sum) {
            //变量声明,辅助问题求解
            int tempMax = list[0];
            int tempMin = list[0];
            int tempSum = 0;

            //求最大值
            for (int i = 0; i < list.Length; i++)
                if (list[i] > tempMax)
                    tempMax = list[i];
            max = tempMax;

            //求最小值
            for (int i = 0; i < list.Length; i++)
                if (list[i] < tempMin)
                    tempMin = list[i];
            min = tempMin;

            //求和
            for(int i = 0; i < list.Length; i++) {
                tempSum += list[i];
            }
            sum = tempSum;

            //求平均值
            average = sum / list.Length;

        }
    }
}
