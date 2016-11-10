using System;

class Program
{
    static void Main(string[] args)
    {
        ulong num = ulong.Parse(Console.ReadLine());   //[0, Math.Max(ulong)]
        int pos = int.Parse(Console.ReadLine());      //[0, 64)
        ulong bit = ulong.Parse(Console.ReadLine());  // 0 or 1
        ulong numMask = 0UL;
        ulong mask = 0UL;
        if (bit == 0)
        {
            mask = (ulong)~(1 << pos);
            numMask = num & mask;
        }
        if (bit == 1)
        {
            mask = (ulong)1 << pos;
            numMask = (num | mask);
        }
        Console.WriteLine(numMask);
    }
}

