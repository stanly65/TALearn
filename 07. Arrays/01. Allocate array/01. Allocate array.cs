using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // [1...20]
            int[] col = new int[n];
            int value = 0;

            for (int i = 0; i < n; i++)
            {
                col[i] = value;
                Console.WriteLine(col[i]);
                value = value + 5;
            }
        }
    }
}
