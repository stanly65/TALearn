using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); //попълваме масива
            }
            int bestCount = 0;
            int startIndex = 0;
            for (int i = 0; i < arr.Length - 1; i++)   // без последния елемент
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++) //от 2-ия до последния елемент
                {
                    if (arr[j - 1] == arr[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    startIndex = i;
                }
            }

            Console.WriteLine(bestCount);
        }
    }
}
