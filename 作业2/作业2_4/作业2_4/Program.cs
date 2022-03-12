using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业2_4
{
    abstract class Shape
    {
        public abstract double Area();
        public abstract void Init();
        public abstract string getType();
    }

    class Rectangle : Shape
    {
        double width;
        double height;
        string type = "rectangle";
        public Rectangle()
        {
            Init();
        }

        public override string getType()
        {
            return type;
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Init()
        {
            Console.WriteLine("insert length rectangle：");
            string widthStr = Console.ReadLine();
            Console.WriteLine("insert width rectangle：");
            string heightStr = Console.ReadLine();
            if (!double.TryParse(widthStr, out width) || !double.TryParse(heightStr, out height))
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("success generate rectangle");
            }
        }
    }

    class Square : Shape
    {
        double sideLength;
        string type = "suqare";

        public Square()
        {
            Init();
        }

        public override string getType()
        {
            return type;
        }
        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return sideLength * sideLength;
        }

        public override void Init()
        {
            Console.WriteLine("insert length square：");
            string sideLengthStr = Console.ReadLine();
            if (!double.TryParse(sideLengthStr, out sideLength))
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("sucess generate square");
            }
        }

    }

    class Triangle : Shape
    {
        double a;
        double b;
        string type = "triangle";
        public Triangle()
        {
            Init();
        }

        public Triangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override string getType()
        {
            return type;
        }
        public override double Area()
        {
            return (a * b) / 2;
        }

        public override void Init()
        {

            Console.WriteLine("insert length triangle：");
            string aStr = Console.ReadLine();
            Console.WriteLine("insert height triangle：");
            string bStr = Console.ReadLine();

            if (!double.TryParse(aStr, out a) || !double.TryParse(bStr, out b))
            {
                Console.WriteLine("error");

            }
            else
            {
                Console.WriteLine("success generate triangle");
            }


        }
    }
    class Factory
    {
        public static Shape GetShape(int name, double width, double height, double sideLength, double a, double b)
        {
            switch (name)
            {
                case 1: return new Rectangle(width, height);
                case 2: return new Square(sideLength);
                case 3: return new Triangle(a, b);
                default:
                    return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double areaSum = 0;
            int i = 0;
            Random ran = new Random();
            while (i < 10)
            {

                int name = ran.Next(1, 4);

                double width = ran.NextDouble() * 10;

                double height = ran.NextDouble() * 10;

                double sideLength = ran.NextDouble() * 10;

                double a = ran.NextDouble() * 10;

                double b = ran.NextDouble() * 10;

                Shape shape = Factory.GetShape(name, width, height, sideLength, a, b);
                if (shape != null)
                {
                    Console.WriteLine("genarate = {0}\r\n size ={1}", shape.getType(), shape.Area().ToString("f2"));
                    areaSum += shape.Area();
                    i++;
                }
            }
            Console.WriteLine("size ={0}", areaSum.ToString("f2"));
            Console.ReadKey();
        }
    }
}
