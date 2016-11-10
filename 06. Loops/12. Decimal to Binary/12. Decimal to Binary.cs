using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary
{
    class Decimal_to_Binary
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string result = DecToBib(number);
            Console.WriteLine(result);
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
            //result = result.PadLeft(32, '0');
            return result;
        }
    }
}