using System;
using System.Collections.Generic;
using System.Linq;

class CheckForPlayCard
{
    static void Main()
    {
        string inp = Console.ReadLine();
      
        switch (inp)

        {
            case "2":
                Console.WriteLine("yes 2");
                break;
            case "3":
                Console.WriteLine("yes 3");
                break;
            case "4":
                Console.WriteLine("yes 4");
                break;
            case "5":
                Console.WriteLine("yes 5");
                break;
            case "6":
                Console.WriteLine("yes 6");
                break;
            case "7":
                Console.WriteLine("yes 7");
                break;
            case "8":
                Console.WriteLine("yes 8");
                break;
            case "9":
                Console.WriteLine("yes 9");
                break;
            case "10":
                Console.WriteLine("yes 10");
                break;
            case "A":
                Console.WriteLine("yes A");
                break;
            case "J":
                Console.WriteLine("yes J");
                break;
            case "Q":
                Console.WriteLine("yes Q");
                break;
            case "K":
                Console.WriteLine("yes K");
                break;
            default:
                Console.WriteLine("no {0}",inp); 
                break;
        }
    }
}



