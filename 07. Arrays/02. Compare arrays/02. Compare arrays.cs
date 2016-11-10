using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // [1...20]
            int[] arrF = new int[n];
            int[] arrS = new int[n];
            for (int i = 0; i < 2 * n; i++)
            {
                if (i < n) arrF[i] = int.Parse(Console.ReadLine());
                else if (i >= n) arrS[i - n] = int.Parse(Console.ReadLine());
            }
            if (arrF.SequenceEqual(arrS)) Console.WriteLine("Equal");
            else Console.WriteLine("Not equal");
        }
    }
}
