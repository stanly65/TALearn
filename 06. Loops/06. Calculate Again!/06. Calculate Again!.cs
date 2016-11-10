using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger s = 1;
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            for (BigInteger i = k+1; i <= n; i++)
            {
                s = s * i;
            }
            Console.WriteLine(s);
        }
    }
}
