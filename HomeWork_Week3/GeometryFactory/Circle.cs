using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFactory
{
    class Circle : Geometry
    {
        private double radius;


        public Circle(double r)
        {
            radius = r;
        }


        public double Radius
        {
            get {
                if (IsLegal())
                    return radius;
                else
                {
                    Console.WriteLine("半径不能为负");
                    return -1;
                }
            }
            set { radius = value; }
        }

        public double GetArea()
        {
            if(IsLegal())
                return Math.PI * radius * radius;
            else
            {
                Console.WriteLine("半径不能为负");
                return -1;
            }
        }

        public bool IsLegal()
        {
            return radius > 0;
        }
    }
}
