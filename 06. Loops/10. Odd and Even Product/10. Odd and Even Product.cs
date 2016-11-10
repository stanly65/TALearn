using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            long odd = 1;
            long even = 1; 
            int temp = 1;
            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    temp = input[i];
                    odd = odd * temp;
                }
                else
                {
                    temp = input[i];
                    even = even * temp;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("yes {0}", odd);
            }
            else
            {
                Console.WriteLine("no {0} {1}",odd, even);
            }
        }
    }
}
