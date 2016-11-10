using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 2.0;
            double distance = Math.Sqrt(x * x + y * y);
            if (distance > r)
            {
                Console.WriteLine("no {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("yes {0:f2}", distance);
            }
        }
    }
}
