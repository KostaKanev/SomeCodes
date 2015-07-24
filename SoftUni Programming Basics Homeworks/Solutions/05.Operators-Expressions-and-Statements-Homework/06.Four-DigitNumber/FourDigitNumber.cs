using System;

public class FourDigitNumber
{
    public static void Main()
    {
        //Read number digit by digit
        Console.Write("Enter number: ");
        int a = Console.Read() - '0';
        int b = Console.Read() - '0';
        int c = Console.Read() - '0';
        int d = Console.Read() - '0';

        //Print results
        Console.WriteLine("The sum of all digits = {0}", a + b + c + d);
        Console.WriteLine("Reversed number = {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in the first = {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchanges digit 2 and 3 = {0}{1}{2}{3}", a, c, b, d);
    }
}
