using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFactory
{
    class Triangle : Geometry
    {
		private double lineA;
		private double lineB;
		private double lineC;

		public Triangle(double a,double b,double c)
		{
			LineA = a;
			LineB = b;
			LineC = c;
		}

		public double LineC
		{
			get 
			{
				if(IsLegal())
					return lineC;
				else
				{
					Console.WriteLine("三角形边长不合法");
					return -1;
				}
			}
			set { lineC = value; }
		}

		public double LineB
		{
			get 
			{
				if (IsLegal())
					return lineB;
				else
				{
					Console.WriteLine("三角形边长不合法");
					return -1;
				}
			}
			set { lineB = value; }
		}

		public double LineA
		{
			get 
			{
				if (IsLegal())
					return lineA;
				else
				{
					Console.WriteLine("三角形边长不合法");
					return -1;
				}
			}
			set { lineA = value; }
		}

		public double GetArea()
		{
			if (IsLegal())
			{
				// 海伦公式
				double p = (lineA + lineB + lineC) / 2;
				double temp = p * (p - lineA) * (p - lineB) * (p - lineC);
				double area = Math.Pow(temp, 0.5);
				return area;
			}
			else
			{
				Console.WriteLine("三角形边长不合法");
				return -1;
			}
		}

		public bool IsLegal()
		{
			bool temp1 = (lineA + lineB) > lineC;
			bool temp2 = (lineA + lineC) > lineB;
			bool temp3 = (lineB + lineC) > lineA;
			return (temp1 && temp2 && temp3 && lineA > 0 && lineB > 0 && lineC > 0);
		}
	}
}
