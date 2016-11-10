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
            BigInteger s = 1; //s= n!/k!
            BigInteger m = 1; //m= (n-k)!
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = k + 1; i <= n; i++)
            {
                s = s * i;
            }
            for (int i = 1; i <= n-k; i++)
            {
                m = m * i;
            }
            Console.WriteLine(s/m);
        }
    }
}
