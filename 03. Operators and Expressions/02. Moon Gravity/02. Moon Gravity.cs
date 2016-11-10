using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moon_Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightManEarth = double.Parse(Console.ReadLine());
            double weightManMoon = weightManEarth * 0.17;
            Console.WriteLine("{0:f3}", weightManMoon);
        }
    }
}
