using System;

public class Program
{
    public static void Main()
    {
        string userInput = Console.ReadLine();
        DateTime birthDate = DateTime.ParseExact(userInput, "MM.dd.yyyy", null);
        DateTime nowDate = DateTime.Now;
        DateTime after10YearsDate = nowDate.AddYears(10);

        var myYears = ((nowDate - birthDate).TotalDays) / 365.25;
        var myYearsAfter10Years = ((after10YearsDate - birthDate).TotalDays) / 365.25;


        Console.WriteLine(Math.Truncate(myYears));
        Console.WriteLine(Math.Truncate(myYearsAfter10Years));
    }
}


