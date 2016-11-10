using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Hex_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string inp = Console.ReadLine();
            char[] hex = inp.ToCharArray();
                       
            long result = 0;
            long power = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int number = 0;
                switch (hex[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = hex[i] - '0'; break;
                }
                result += power * number;
                power *= 16;
            }
                     
            Console.WriteLine(result);
        }
    }
}
