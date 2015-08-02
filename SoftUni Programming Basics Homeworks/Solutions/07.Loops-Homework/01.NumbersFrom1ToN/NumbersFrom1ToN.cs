using System;

public class NumbersFrom1ToN
{
    public static void Main()
    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers from 1 to your number\n" + new string('-', 20));
        for (int counter = 1; counter <= number; counter++)
        {
            Console.Write(counter + " ");
        }
        Console.WriteLine();
    }
}
