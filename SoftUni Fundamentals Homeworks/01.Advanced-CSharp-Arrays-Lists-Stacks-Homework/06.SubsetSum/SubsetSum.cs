using System;
using System.Collections.Generic;
using System.Linq;

public class SubsetSums
{
    public static void Main()
    {
        int neededSum = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        var numbers = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            numbers.Add(int.Parse(input[i]));
        }

        var subsets = new List<List<int>>();
        
        subsets = MakeSubsets(numbers);

        for (int i = 0; i < subsets.Count; i++)
        {
            int[] currentSubset = subsets[i].ToArray();
            if (subsets[i].Sum() == neededSum)
            {
                Console.Write(string.Join<int>(" + ", subsets[i]));
                Console.WriteLine(" = {0}", neededSum);
            }
        }
    }

    public static List<List<int>> MakeSubsets (List<int> numbers)
    {
        var result = new List<List<int>>();

        for (int i = 0; i < Math.Pow(2,numbers.Count); i++)
        {
            result.Add(new List<int>());
            for (int index = 0; index < numbers.Count; index++)
            {
                int currentBit = GetBitAtPosition(i,index);
                if (currentBit == 1)
                {
                    result[i].Add(numbers[index]);
                }
            }
        }
        return result;
    }

    public static int GetBitAtPosition(int number, int bitPosition)
    {
        int mask = 1 << bitPosition;
        int numAndMask = number & mask;
        int bit = numAndMask >> bitPosition;
        return bit;
    }
}