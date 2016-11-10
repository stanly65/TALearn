using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringFirst = Console.ReadLine();
            string stringSecond = Console.ReadLine();
            //char[] arrF = stringFirst.ToCharArray();
            //char[] arrS = stringSecond.ToCharArray();

            var result = string.Compare(stringFirst, stringSecond, StringComparison.Ordinal);
            if (result > 0)
                Console.WriteLine(">");
            else if (result < 0)
            {
                Console.WriteLine("<");
            }
            else Console.WriteLine("=");
        }
    }
}
