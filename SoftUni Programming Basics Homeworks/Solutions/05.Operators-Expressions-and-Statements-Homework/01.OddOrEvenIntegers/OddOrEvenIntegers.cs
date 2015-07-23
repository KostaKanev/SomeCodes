using System;
public class OddOrEvenIntegers
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool isOdd = true;
        if (number % 2 == 0)
        {
            isOdd = false;
        }
        Console.WriteLine("Is Odd: {0}", isOdd);
    }
}
