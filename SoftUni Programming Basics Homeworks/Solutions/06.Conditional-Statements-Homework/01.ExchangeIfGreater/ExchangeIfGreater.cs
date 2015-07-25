using System;
public class ExchangeIfGreater
{
    public static void Main()
    {
        //Read two numbers from the console
        Console.Write("Enter number A: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        double numberB = double.Parse(Console.ReadLine());
        double help = 0;

        if (numberA > numberB)
        {
            //Exchange values
            help = numberA;
            numberA = numberB;
            numberB = help;
        }
        
        //Print result
        Console.WriteLine("{0} {1}", numberA, numberB);
    }
}