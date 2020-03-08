using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFactory
{
    enum ShapeType
    {
        Circle,
        Rectangle,
        Square,
        Triangle
    }

    class Factory
    {
        public static Geometry GetGeometry(ShapeType shape,params double[] initalInfo)
        {
            switch (shape)
            {
                case ShapeType.Rectangle:
                    {
                        // 如果为矩形
                        if (initalInfo.Length != 2)
                        {
                            throw new Exception("长方形初始化参数数量错误");
                        }
                        return new Rectangle(initalInfo[0], initalInfo[1]);
                    }
                case ShapeType.Square:
                    {
                        // 如果为正方形
                        if (initalInfo.Length != 1)
                        {
                            throw new Exception("正方形初始化参数数量错误");
                        }
                        return new Square(initalInfo[0]);
                    }
                case ShapeType.Triangle:
                    {
                        // 如果为三角形
                        if (initalInfo.Length != 3)
                        {
                            throw new Exception("三角形初始化参数数量错误");
                        }
                        return new Triangle(initalInfo[0], initalInfo[1], initalInfo[2]);
                    }
                case ShapeType.Circle:
                    {
                        // 如果为圆形
                        if (initalInfo.Length != 1)
                        {
                            throw new Exception("圆形初始化参数数量错误");
                        }
                        return new Circle(initalInfo[0]);
                    }
                default:
                    {
                        throw new Exception("图形类型选择错误");
                    }
            }
            
        }

        public static void RandomGeometry(int count)
        {
            //变量声明
            int radius;
            int len;
            int wid;
            int lineA, lineB, lineC;
            int side;
            int shape = 0;
            double sumArea = 0; //总面积
            Geometry temp = null;
            Random random = new Random();
            List<Geometry> geometryList = new List<Geometry>();//用来存放生成的形状

            // 随机生成十个形状，计算面积并在命令行输出,从0到3随机，对应枚举里的数据
            for(int i = 0; i <count; i++)
            {
                shape = random.Next(4);//生成0--3的随机数

                switch (shape)
                {
                    case 0:
                        {
                            radius = random.Next(1, 11);//1到10之间的随机数
                            temp = GetGeometry(ShapeType.Circle, radius);
                            geometryList.Add(temp);
                            Console.WriteLine($"第 {i + 1} 个几何形状为：圆形,面积为 {temp.GetArea()}");
                            break;
                        }
                    case 1:
                        {
                            len = random.Next(1, 11);
                            wid = random.Next(1, 11);
                            temp = GetGeometry(ShapeType.Rectangle, len, wid);
                            geometryList.Add(temp);
                            Console.WriteLine($"第 {i + 1} 个几何形状为：矩形，面积为 {temp.GetArea()}");
                            break;
                        }
                    case 2:
                        {
                            side = random.Next(1, 11);
                            temp = GetGeometry(ShapeType.Square, side);
                            geometryList.Add(temp);
                            Console.WriteLine($"第 {i + 1} 个几何形状为：正方形，面积为 {temp.GetArea()}");
                            break;
                        }
                    case 3:
                        {
                            lineA = lineB = lineC = random.Next(1, 11);//假设三角形为等边三角形
                            temp = GetGeometry(ShapeType.Triangle, lineA, lineB, lineC);
                            geometryList.Add(temp);
                            Console.WriteLine($"第 {i + 1} 个几何形状为：三角形，面积为 {temp.GetArea()}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("随机选择形状过程出错");
                            break;
                        }
                }
            }

            // 计算面积
            foreach(Geometry geo in geometryList)
            {
                sumArea += geo.GetArea();
            }

            Console.WriteLine($"十个图形的总面积为{sumArea}");
        }
    }
}
