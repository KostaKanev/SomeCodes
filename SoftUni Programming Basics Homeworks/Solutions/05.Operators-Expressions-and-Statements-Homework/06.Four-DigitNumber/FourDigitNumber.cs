using System;

public class FourDigitNumber
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        char a = (char)Console.Read();
        char b = (char)Console.Read();
        char c = (char)Console.Read();
        char d = (char)Console.Read();
        
        //Print results
        Console.WriteLine("The sum of all digits = {0}", (a - '0') + (b - '0') + (c - '0') + (d - '0'));
        Console.WriteLine("Reversed number = {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in the first = {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchanges digit 2 and 3 = {0}{1}{2}{3}", a, c, b, d);
    }
}
