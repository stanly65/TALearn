using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWork
{
    class testWork
    {
        static void Main(string[] args)
        {

            byte value = 0;
            int i;
            byte b;
            Console.Write("Enter the integer number i:");
            bool isiInt = int.TryParse(Console.ReadLine(), out i);
            Console.Write("Enter the position of the bit b:");
            bool isbByte = byte.TryParse(Console.ReadLine(), out b);

            if (isiInt && isbByte && b < 32)
            {
                int mask = 1 << b;
                if ((i & mask) == mask)
                {
                    value = 1;
                }
                Console.WriteLine("value={0}", value);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
