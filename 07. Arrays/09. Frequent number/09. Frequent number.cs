using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int index = 0; index < n; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }
            // group by value and count frequency
            //from - Указание источника данных и переменной диапазона(аналогично переменной итерации).
            var query = from i in arr
                        group i by i into g
                        select new { g.Key, Count = g.Count() };

            // compute the maximum frequency
            int whatsTheFrequencyKenneth = query.Max(g => g.Count);

            // find the values with that frequency
            IEnumerable<int> modes = query
                                          .Where(g => g.Count == whatsTheFrequencyKenneth)
                                          .Select(g => g.Key);
            
            // dump to console
            foreach (var mode in modes)
            {
                Console.WriteLine("{0} ({1} times)", mode, whatsTheFrequencyKenneth);
            }
        }
    }
}
