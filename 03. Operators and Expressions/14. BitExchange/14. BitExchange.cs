using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string num = DecToBib(number);
            char[] array = num.ToCharArray();
            List<int> list = new List<int>();
            list = array.Select(c => Convert.ToInt32(c.ToString())).ToList();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i]);
            //}
            //Console.WriteLine();
            int canger24 = BitValue(number, 3);
            int canger25 = BitValue(number, 4);
            int canger26 = BitValue(number, 5);
            int canger3 = BitValue(number, 24);
            int canger4 = BitValue(number, 25);
            int canger5 = BitValue(number, 26);
            list.Reverse();
            list.RemoveRange(24, 3);
            list.Insert(24, canger24);
            list.Insert(25, canger25);
            list.Insert(26, canger26);
            list.RemoveRange(3, 3);
            list.Insert(3, canger3);
            list.Insert(4, canger4);
            list.Insert(5, canger5);

            list.Reverse();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i]);
            //}

            var input = string.Join("", list);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i]);
            //}
            long output = Convert.ToInt64(input, 2);
            Console.WriteLine(output);
        }
        static int BitValue(ulong num, int pos)
        {
            ulong mask = (ulong)(1 << pos);
            ulong numAndMask = num & mask;
            ulong bit = numAndMask >> pos;
            return (int)bit;
        }
        static string DecToBib(ulong number)
        {
            ulong remainder = 0;   // декларираме цялочислена променлива "остатък"
            string result = ""; // декларираме празен стринг "резултат"
            while (number > 0) //Завъртаме непрекъснат цикъл докато променливата  decimalNumber > 0
            {                         // Въвели сме от конзолата число >0 и условието е изпълнено
                remainder = number % 2; //За четно число "остатъка" = 0, за нечетно remainder = 1
                number /= 2; // намаляваме наполовина стойността на променливата decimalNumber( dN = dN/2)
                result = remainder.ToString() + result; // "Остатъка" (0 или 1) стрингосваме и натрупваме в променливата result (001011...)
                                                        // отново проверяваме условието с новата стойност на decimalNumber (15/2 = 7/2 =3/2 =1, 1/2 =0
            }
            result = result.PadLeft(32, '0');
            return result;
        }
    }
}

