﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Not_Divisible_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 7 == 0 || i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
