using System;

public class Claculate
{
    public static void Main()
    {
        Console.WriteLine("Calculate 1 + 1!/X + 2!/X^2 + ... + N!/X^n\n");
        Console.Write("Please enter N: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Please enter X: ");
        double x = double.Parse(Console.ReadLine());

        double result = 1;
        double factorial = 1;
        for (double i = 1; i <= n; i++)
        {
            factorial *= i;
            result += factorial / Math.Pow(x, i);
        }
        Console.WriteLine("Result = {0:F5}", result);
    }
}