using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Point__Circle__Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Point p = new Point { X = x, Y = y };
            Point centr = new Point { X = 1, Y = 1 };
            double radius = 1.5;
            Rectangle rec = new Rectangle { Top = 1, Left = -1, Width = 6, Height = 2 };

            string result2 = IsInsideR(p, rec);
            string result1 = IsInsideC(p, centr, radius);
            Console.WriteLine(result1 + " " + result2);

        }

        public static string IsInsideR(Point p, Rectangle r)
        {

            if ((r.Left <= p.X) && (r.Right >= p.X) && (r.Top >= p.Y) && (r.Bottom <= p.Y))
            {
                return "inside rectangle";
            }
            else return "outside rectangle";
        }

        public static string IsInsideC(Point p, Point centr, double radius)
        {
            double deltaX = p.X - centr.X;
            double deltaY = p.Y - centr.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (radius >= distance)
            {
                return "inside circle";
            }
            else return "outside circle";
        }

    }
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Bottom
        {
            get
            {
                return Top - Height;
            }
        }
        public double Right
        {
            get
            {
                return Left + Width;
            }
        }
    }
}
