using System;
using System.Linq;

public class FirstLargerThanNeighbours
{
    public static void Main()
    {
        //int[] numbers1 = { 1, 3, 4, 5, 1, 0, 5 };
        //int[] numbers2 = { 1, 2, 3, 4, 5, 6, 6 };
        //int[] numbers3 = { 1, 1, 1 };

        int[] input = Console.ReadLine().Split(' ').Select(element => int.Parse(element)).ToArray();
        Console.WriteLine(FirstLargerNumIndex(input));
    }

    public static int FirstLargerNumIndex(int[] sequence)
    {
        int bestIndex = 0;
        int countOfBestIndexes = 0;

        for (int index = 1; index < sequence.Length - 1; index++)
        {
            
            if (sequence[index] > sequence[index - 1] &&
                sequence[index] > sequence[index + 1])
            {
                bestIndex = index;
                countOfBestIndexes++;
            }
        }
        if (countOfBestIndexes != 0)
        {
            return bestIndex;
        }
        else
        {
            return -1;
        }
        
    }
}