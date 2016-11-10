using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decimal_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
           
            long num = long.Parse(Console.ReadLine());
            string hex = "";
            while (num != 0) 
            {
                long rem = num % 16;

                switch (rem)
                {
                    case 10: hex = "A" + hex; break;
                    case 11: hex = "B" + hex; break;
                    case 12: hex = "C" + hex; break;
                    case 13: hex = "D" + hex; break;
                    case 14: hex = "E" + hex; break;
                    case 15: hex = "F" + hex; break;
                    default: hex = rem + hex; break;
                }
                num = num/ 16;
            }
            Console.WriteLine(hex);
        }
    }
}
