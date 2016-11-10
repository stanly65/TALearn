using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); //попълваме масива
            }
            var res1 = arr.OrderByDescending(x => x);  //сотрираме от arr[0] най-голямо към най-малко
            var res2 = res1.Take(k);                   // прави редица от първите k елемента
            var res3 = res2.Sum();                     // сумира ги

            Console.WriteLine(res3);

        }
    }
}
