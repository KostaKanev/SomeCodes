using System;
public class NumbersNotDivisibleBy3and7
{
    public static void Main()
    {
        Console.Write("Please enter Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers from 1 to Number not divisible by 3 and 7\n" + new string('-',50));
        for (int counter = 1; counter <= number; counter++)
        {
            if (counter % 3 != 0 && counter % 7 != 0)
            {
                Console.Write(counter + " ");
            }
         }
        Console.WriteLine();
    }
}