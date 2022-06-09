using System;
using System.Collections.Generic;

namespace Logical_Problems;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a no to go to respective problem");
        Console.WriteLine("1 for Perfect number");
        Console.WriteLine("2 for Prime number");
        Console.WriteLine("3 for Reverse number");
        Console.WriteLine("4 for StopWatch");
        Console.WriteLine("5 for Febonacci Series");

        int Option = Convert.ToInt32(Console.ReadLine());

        switch (Option)
        {
            case 1:
                Perfect_No perfect = new Perfect_No();
                perfect.perfectnum();
                break;
            case 2:
                Prime_No prime = new Prime_No();
                prime.Prime();
                break;
            case 3:
                Reverse_No reverse = new Reverse_No();
                reverse.Reverse();
                break;
            case 4:
                Stop_Watch stopWatch = new Stop_Watch();
                stopWatch.Stop();
                break;
            case 5:
                Febonacci febonacci = new Febonacci();
                febonacci.Febonacci_Series();
                break;




        }
    }
}
 