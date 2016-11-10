using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        long sum = 0;
        long n = long.Parse(Console.ReadLine());
        bool[] e = new bool[n];//by default they're all false
        for (int i = 2; i < n; i++)
        {
            e[i] = true;//set all numbers to true
        }
        //weed out the non primes by finding mutiples 
        for (int j = 2; j < n; j++)
        {
            if (e[j])//is true
            {
                for (long p = 2; (p * j) < n; p++)
                {
                    e[p * j] = false;
                }
            }
        }
        Console.WriteLine();
        //Uptill here e[] sorta of contains a list of primes
        //the index represent the actual number and the value at the index represents if the number is prime
        //Example:
        //e[4], e[100] will all be false since 2,4,100 are not primes
        //e[5], e[7], e[11], e[13] will all be true because 5,7,11,13 are all prime numbers
    }
}