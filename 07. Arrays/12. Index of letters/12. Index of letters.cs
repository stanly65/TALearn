using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> ls = new List<char>();
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                ls.Add(ch);
            }
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int result = ls.BinarySearch(arr[i]);
                Console.WriteLine(result);
            }
        }
    }
}
