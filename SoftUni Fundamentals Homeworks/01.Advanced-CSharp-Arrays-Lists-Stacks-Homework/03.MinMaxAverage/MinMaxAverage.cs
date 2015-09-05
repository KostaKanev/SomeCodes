using System;
using System.Collections.Generic;

public class MinMaxAverage
{
    public static void Main()
    {
        //Read numbers with spaces like string
        string[] input = Console.ReadLine().Split(' ');
        double[] numbers = new double[input.Length];

        //Transfer parsed to integer numbers in int array
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }
        
        //Categorize the numbers
        List<double> roundedNums = new List<double>();
        List<double> floatingNums = new List<double>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 == 0)
            {
                roundedNums.Add(numbers[i]);
            }
            else
            {
                floatingNums.Add(numbers[i]);
            }
        }

        //Find values for rounded numbers
        double minRounded = double.MaxValue;
        double maxRounded = double.MinValue;
        double sumRounded = roundedNums[0];
        for (int i = 0; i < roundedNums.Count - 1; i++)
        {
            sumRounded += roundedNums[i + 1];
            if (minRounded > Math.Min(roundedNums[i], roundedNums[i + 1]))
            {
                minRounded = Math.Min(roundedNums[i], roundedNums[i + 1]);
            }
            if (maxRounded < Math.Max(roundedNums[i], roundedNums[i + 1]))
            {
                maxRounded = Math.Max(roundedNums[i], roundedNums[i + 1]);
            }
        }
        double aveRounded = sumRounded / roundedNums.Count;

        //Find values for floating point numbers
        double minFloating = double.MaxValue;
        double maxFloating = double.MinValue;
        double sumFloating = floatingNums[0];
        
        for (int i = 0; i < floatingNums.Count - 1; i++)
        {
            sumFloating += floatingNums[i + 1];
            if (minFloating > Math.Min(floatingNums[i], floatingNums[i + 1]))
            {
                minFloating = Math.Min(floatingNums[i], floatingNums[i + 1]);
            }
            if (maxFloating < Math.Max(floatingNums[i], floatingNums[i + 1]))
            {
                maxFloating = Math.Max(floatingNums[i], floatingNums[i + 1]);
            }
        }
        double aveFloating = sumFloating / floatingNums.Count;

        //Print the results

        Console.Write("[ ");
        foreach (var item in roundedNums)
        {
            Console.Write(item + " ");
        }
        Console.Write(']');
        Console.WriteLine("-> min: {0} max: {1} sum: {2} avg: {3}", minRounded, maxRounded, sumRounded, aveRounded);
        Console.Write("[ ");
        foreach (var item in floatingNums)
        {
            Console.Write(item + " ");
        }
        Console.Write(']');
        Console.WriteLine("-> min: {0} max: {1} sum: {2} avg: {3}", minFloating, maxFloating, sumFloating, aveFloating);
    }
}