using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<int> ls = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                ls.Add(temp);
            }
            List<int> sortLs = new List<int>();
            var res = ls.OrderBy(x => x);
            sortLs = res.ToList();
            for (int i = 0; i < sortLs.Count; i++)
            {
                Console.WriteLine(sortLs[i]);
            }
        }
    }
}
