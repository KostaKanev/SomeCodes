using System;
using System.Collections.Generic;

public class LongestIncreasingSequence
{
    public static void Main()
    {

        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        List<List<int>> sequences = new List<List<int>>();
        sequences.Add(new List<int>());
        int currentSequence = 0;
        List<int> longestSequence = new List<int>();
        int index = 1;
        for (int i = 0; i < numbers.Length; i++, index++)
        {
            
            if (index == numbers.Length && numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
            {
                sequences[currentSequence].Add(numbers[index - 1]);
                break;
            }
            else if(index == numbers.Length)
            {
                sequences.Add(new List<int>()); 
                currentSequence++;
                sequences[currentSequence].Add(numbers[i]);
                    
                break;
            }

            if (numbers[i + 1] > numbers[i])
            {
                sequences[currentSequence].Add(numbers[i]);
            }
            else
            {
                sequences[currentSequence].Add(numbers[i]);
                sequences.Add(new List<int>());
                currentSequence++;
            }
        }

        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count == 0)
            {
                sequences.Remove(sequences[i]);
            }
        }

        longestSequence = sequences[0];
        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count > longestSequence.Count)
            {
                longestSequence = sequences[i];
            }
        }

        for (int i = 0; i < sequences.Count; i++)
        {
            for (int j = 0; j < sequences[i].Count; j++)
            {
                Console.Write(sequences[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("Longest: ");
        foreach (var item in longestSequence)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}