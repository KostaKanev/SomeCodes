using System;
public class NumberComparer
{
    public static void Main()
    {
        //Read input from console and parse to double 
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        //Print greater number with Math.Max method
        Console.WriteLine(Math.Max(firstNumber,secondNumber));
    }
}