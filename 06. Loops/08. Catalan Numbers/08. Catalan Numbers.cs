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
            BigInteger x = 1; //x= n!
            BigInteger y = 1; //y= (2*n)! result = y/(x*z)
            BigInteger z = 1; //z= (n+1)!
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
            }
            for (int i = 1; i <= 2*n; i++)
            {
                y = y * i;
            }
            for (int i = 1; i <= (n+1); i++)
            {
                z = z * i;
            }       
            Console.WriteLine(y / (x * z));
        }
    }
}
