using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = 0;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                temp = b;
                b = a;
                a = temp;

                Console.WriteLine(a + " " + b);
            }
            else Console.WriteLine(a + " " + b);
        }
    }
}
