using System;
public class SumOf5Numbers
{
    public static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        double result = 0;

        foreach (var num in numbers)
        {
            result += double.Parse(num);
        }
        Console.WriteLine(result);
    }
}