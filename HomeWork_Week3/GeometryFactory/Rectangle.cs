using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFactory
{
    class Rectangle : Geometry
    {
        // 长宽只能当前类和子类能够访问
        protected double length;//长
        protected double width;//宽

        public Rectangle(double len, double wid)
        {
            Length = len;
            Width = wid;
        }

        public double Width
        {
            get 
            { 
                if(IsLegal())
                    return width;
                else
                {
                    Console.WriteLine("长方形的长和宽均不能为负数");
                    return -1;
                }
            }
            set { width = value; }
        }

        public double Length
        {
            get 
            { 
                if(IsLegal())
                    return length;
                else
                {
                    Console.WriteLine("长方形的长和宽均不能为负数");
                    return -1;
                }
            }
            set { length = value; }
        }


        public virtual double GetArea()
        {
            if(IsLegal())
                return Width * Length;
            else
            {
                Console.WriteLine("长方形的长和宽均不能为负数");
                return -1;
            }
        }

        public virtual bool IsLegal()
        {
            // 判断当前图形本身是否合法
            return (width > 0 && length > 0);//这里只能用字段，如果使用属性的话，IsLegal和Width、Length的Get会相互调用，导致栈溢出
        }
    }
}
