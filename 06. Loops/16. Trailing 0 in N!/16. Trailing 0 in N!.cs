using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger x = 1; 
        int count = 0;

        //for (int i = 1; i <= n; i++)
        //{
        //    x = x * i;
        //}
        //while (x % 10 == 0)
        //{
        //    ++count;
        //    x = x / 10;
        //}
        int sum = 5; // n/5 + n/25 + n/125 + … = the number of trailing zeroes in N!
        while (n>=sum)
        {
            count = count + (n / sum);
            sum = sum * 5;
        }

        Console.WriteLine(count);
    }
}

