using System;

public class MinMaxSumAverageOfNnumbers
{
    public static void Main()
    {
        Console.Write("Please enter count of numbers: ");
        int numbersCount = int.Parse(Console.ReadLine());

        double[] numbers = new double[numbersCount];
        double minimal = double.MaxValue;
        double maximal = double.MinValue;
        double sum = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            //Read numbers
            numbers[i] = double.Parse(Console.ReadLine());

            //Check for minimal value
            if (numbers[i] < minimal)
            {
                minimal = numbers[i];
            }
            //Check for maximal value
            if (numbers[i] > maximal)
            {
                maximal = numbers[i];
            }
            //Find sum of number
            sum += numbers[i];
        }
        //Calculate average value
        double average = sum / numbersCount;


        //Print results
        Console.WriteLine("Minimal Value: {0}", minimal);
        Console.WriteLine("Maximal Value: {0}", maximal);
        Console.WriteLine("Sum of numbers: {0}", sum);
        Console.WriteLine("Average Value: {0:F2}", average);
    }
}