using System;

public class SortArraysOfNumbers
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
        //Sort the array with function
        Array.Sort(numbers);

        //Print sorted result
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}