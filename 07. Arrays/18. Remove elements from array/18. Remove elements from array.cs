using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        int[] seq = new int[n];
        for (int i = 0; i < n; i++)
        {
            seq[i] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (num[j] <= num[i])
                {
                    seq[i] = Math.Max(seq[i], seq[j] + 1);
                }
            }
        }
        Console.WriteLine(n - seq.Max());
    }
}