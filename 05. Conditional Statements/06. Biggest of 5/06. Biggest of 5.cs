using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());


            double x = Math.Max(a, b);
            double y = Math.Max(c, d);
            double z = Math.Max(x, y);
            double rezult = Math.Max(z, e);
            
            Console.WriteLine(rezult);
        }
    }
}
