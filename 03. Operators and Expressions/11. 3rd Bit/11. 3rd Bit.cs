using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3rd_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number10 = int.Parse(Console.ReadLine());
            int pos = 3;
            int mask = 1 << pos;
            int numAndMask = number10 & mask;
            int bit = numAndMask >> pos;
            Console.WriteLine(bit);
        }
    }
}

