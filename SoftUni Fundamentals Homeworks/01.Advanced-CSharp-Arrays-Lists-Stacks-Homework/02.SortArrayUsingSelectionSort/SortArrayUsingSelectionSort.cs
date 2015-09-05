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
        
        //Sort the array using sorting algorithm
        int swapsCount = 0;
        int lastChangedIndex = numbers.Length - 1;
        do
        {
            swapsCount = 0;
            
            for (int index = 0; index < lastChangedIndex; index++)
            {
                if (numbers[index] > numbers[index + 1])
                {
                    int temp = numbers[index];
                    numbers[index] = numbers[index + 1];
                    numbers[index + 1] = temp;

                    swapsCount++;
                }
            }
            lastChangedIndex--;
        } while (swapsCount != 0);

        //Print the sorted array
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}