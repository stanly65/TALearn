using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int c = 0; c < n; c++)
            {
                for (int r = 1; r <= n; r++)
                {
                    Console.Write("{0} ", r + c);
                }
                Console.WriteLine();
            }
        }
    }
}
