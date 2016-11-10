using System;

public class Program
{

    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double aAbs = Math.Abs(a);
        double bAbs = Math.Abs(b);

        double aPrecision6 = Math.Round(aAbs, 6);
        double bPrecision6 = Math.Round(bAbs, 6);

        bool isTrue = aPrecision6.Equals(bPrecision6); //True or False
        string result = isTrue.ToString().ToLower();
        Console.WriteLine(result);                     //true or false
    }
}
