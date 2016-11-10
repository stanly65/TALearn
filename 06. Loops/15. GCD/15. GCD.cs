// wikipedia: Най-голям общ делител
// Алгоритъм на Евклид
//1) За делимо се взима по-голямото число, а за делител - по-малкото число.
//2) Делителя от своя страна се дели на остатъка от частното
//3) Това се повтаря дотогава, докато частното има остатък.
// НОД(18,84)
// 84 : 18 = 4.12 // 84 % 18 = 12
// 18 : 12 = 1.6  // 18 % 12 = 6
// 12 : 6 = 2     // 12 % 6 = 0    => Greatest Common Divisor = 6
// НОД = 6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var inp = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int a = inp[0];
            int b = inp[1];

            if (a < b) // a винаги да е по-голямото число - делимото!
            {
                int temp = a;
                a = b;
                b = temp;
            }

            int intNum = 0;
            int remNum = 0;

            //Console.WriteLine();
            do
            {
                intNum = a / b;
                remNum = a % b;

                a = b;
                b = remNum;
            }
            while (remNum != 0);

            Console.WriteLine(a);
        }
    }
}

