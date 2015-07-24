using System;

class FourDigitNumber
{
    static void Main()
    {
        //Read number from console like string
        Console.Write("Enter number: ");
        char[] digits = new char[4];
        int sum = 0;

        //Make array with all digits and calculate its sum
        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = (char)Console.Read();
            sum += digits[i] - '0';
        }

        //Print results
        Console.WriteLine("The sum of all digits = {0}", sum);
        Console.WriteLine("Reversed number = {0}{1}{2}{3}", digits[3], digits[2], digits[1], digits[0]);
        Console.WriteLine("Last digit in the first = {0}{1}{2}{3}", digits[3], digits[0], digits[1], digits[2]);
        Console.WriteLine("Exchanges digit 2 and 3 = {0}{1}{2}{3}", digits[0], digits[2], digits[1], digits[3]);
    }
}