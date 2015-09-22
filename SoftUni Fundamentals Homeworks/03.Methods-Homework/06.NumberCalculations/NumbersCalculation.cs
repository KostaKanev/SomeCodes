using System;

public class NumbersCalculation
{
    public static void Main()
    {
        double[] doubleNumbers = { 1.2, 2.3, 3.4, 4.5, 5.6 };
        decimal[] decimalNumbers = { 9.8m, 8.7m, 7.6m, 6.5m, 5.4m, 4.3m };

        Console.WriteLine(GetMax(doubleNumbers));
        Console.WriteLine(GetMax(decimalNumbers));
    }

    //Get maximal element of numbers set
    public static double GetMax(double[] numbers)
    {
        double max = double.MinValue;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    public static decimal GetMax(decimal[] numbers)
    {
        decimal max = decimal.MinValue;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    //Get minamal element of numbers set
    public static double GetMin(double[] numbers)
    {
        double min = double.MaxValue;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    public static decimal GetMin(decimal[] numbers)
    {
        decimal min = decimal.MaxValue;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    //Get average value of numbers set
    public static double GetAverage(double[] numbers)
    {
        double average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
        }
        return average / numbers.Length;
    }
    public static decimal GetAverage(decimal[] numbers)
    {
        decimal average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
        }
        return average / numbers.Length;
    }
    //Get sum of element of numbers set
    public static double GetSum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    public static decimal GetSum(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    //Get product of elements of numbers set
    public static double GetProduct(double[] numbers)
    {
        double product = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
    public static decimal GetProduct(decimal[] numbers)
    {
        decimal product = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}