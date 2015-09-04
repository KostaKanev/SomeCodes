using System;

public class SortArrayUsingSelectionSort
{
    public static void Main()
    {
        //Read numbers with spaces like string
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];

        //Transfer parsed to integer numbers in int array
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        
        int counts = 0;
        int helper = 0;

        do
        {
            counts = 0;
            
            for (int index = 0; index < numbers.Length - 1; index++)
            {
                if (numbers[index] > numbers[index + 1])
                {
                    helper = numbers[index];
                    numbers[index] = numbers[index + 1];
                    numbers[index + 1] = helper;

                    counts++;
                }
            }
        } while (counts != 0);

        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}