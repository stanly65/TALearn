using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double f = 1d;
            double p = 0d;
            double s = 0d;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
                p = Math.Pow(x, i);
                s += (f / p);
            }
            Console.WriteLine("{0:F5}", s + 1);
        }
    }
}
