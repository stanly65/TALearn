//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _03.MMSA_of_N_Numbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double min;
//            double max;
//            double sum;
//            double avg;
//            List<double> num = new List<double>();
//            int n = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= n; i++)
//            {
//                double temp = double.Parse(Console.ReadLine());
//                num.Add(temp);
//            }
//            min = num.Min();
//            max = num.Max();
//            sum = num.Sum();
//            avg = num.Average();

//            Console.WriteLine("min={0:F2}", min);
//            Console.WriteLine("max={0:F2}", max);
//            Console.WriteLine("sum={0:F2}", sum);
//            Console.WriteLine("avg={0:F2}", avg);
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = 10001d;
            double max = -10001d;
            double sum = 0d;
            double avg = 0d;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double temp = double.Parse(Console.ReadLine());
                if (temp < min) min = temp;
                if (temp > max) max = temp;
                sum += temp;
            }
            avg = sum / n;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
    }
}
