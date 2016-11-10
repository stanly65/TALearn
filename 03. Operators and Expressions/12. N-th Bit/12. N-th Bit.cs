using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.N_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            //start:
            ulong num = ulong.Parse(Console.ReadLine());
             int pos = int.Parse(Console.ReadLine());
            var result = BitValue(num, pos);
            Console.WriteLine(result);
           //goto start;
        } 
        static ulong BitValue(ulong num, int pos)
        {
            ulong mask = (ulong)(1 << pos);
            ulong numAndMask = num & mask;
            ulong bit = numAndMask >> pos;
            return bit;
        } 
    }
}
