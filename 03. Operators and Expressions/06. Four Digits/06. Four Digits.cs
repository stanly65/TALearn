using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int d = input % 10;
            int c = (input / 10) % 10;
            int b = (input / 100) % 10;
            int a = input / 1000;
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("" + d + c + b + a);
            Console.WriteLine("" + d + a + b + c);
            Console.WriteLine("" + a + c + b + d);
        }
    }
}
