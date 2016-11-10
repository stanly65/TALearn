using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputB = Console.ReadLine();
            var iE = inputB.Reverse().Select(digit => int.Parse(digit.ToString()));
            List<int> num = iE.ToList();
            double numD = 0;
            
            for (int i = num.Count()-1; i >= 0; i--)
            {
                numD += num[i]*Math.Pow(2,i);
            }
            Console.WriteLine(numD);
        }
    }
}
