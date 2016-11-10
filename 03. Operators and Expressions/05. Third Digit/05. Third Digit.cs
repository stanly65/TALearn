using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input / 100;
            int thirdDigit = number % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                //Console.WriteLine($"false {thirdDigit}"); //? Грешка при компилация
                Console.WriteLine("false {0}", thirdDigit);

            }
        }
    }
}
