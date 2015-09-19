using System;
using System.Linq;
public class SortArrayUsingSelectionSort
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(element => int.Parse(element)).ToArray();
       
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

        Console.WriteLine(string.Join(" ", numbers));
    }
}
