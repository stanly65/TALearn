using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input % 5 == 0 && input % 7 == 0)
            {
                Console.WriteLine("true {0}", input);
            }
            else
            {
                Console.WriteLine("false {0}", input);
            }
        }
    }
}
