using System;
public class SumOfNnumbers
{
    public static void Main()
    {
        //Read count of numbers from the console
        int count = int.Parse(Console.ReadLine());
        
        //Fill double array with [count] numbers
        double[] numbers = new double[count];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        //Calculate and print the sum of numbers
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        Console.WriteLine(sum);
    }
}