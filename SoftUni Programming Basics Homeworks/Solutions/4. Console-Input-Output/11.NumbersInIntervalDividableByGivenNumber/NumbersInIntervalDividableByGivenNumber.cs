using System;
public class NumbersInIntervalDividableByGivenNumber
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int countOfNumbers = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                countOfNumbers++;
            }
        }
        Console.WriteLine(countOfNumbers);
    }
}
