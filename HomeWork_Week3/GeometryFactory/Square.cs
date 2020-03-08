using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFactory
{
    class Square : Rectangle
    {

        private double side;

        public Square(double side) : base(side, side)
        {
            Side = side;
        }


        public double Side
        {
            get 
            { 
                if(IsLegal())
                    return side;
                else
                {
                    Console.WriteLine("正方形边长不能为负数");
                    return -1;
                }
            }
            set { side = value; }
        }


        public override double GetArea()
        {
            if(IsLegal())
                return side * side;
            else
            {
                Console.WriteLine("正方形边长不能为负数");
                return -1;
            }
        }

        public override bool IsLegal()
        {
            if (length != width || side < 0)
                return false;
            else
                return true;
        }
    }
}
