using System;
using System.Numerics;

public class CatalanNumbers
{
    public static void Main()
    {
        Console.WriteLine("Calculate Nth Catalan number");
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger numinator = 1;
        BigInteger denominator = 1;

        //Calculate Catalan number
        for (int k = 2; k <= n; k++)
        {
            numinator *= n + k;
            denominator *= k;
        }

        BigInteger nthCatalanNumber = numinator / denominator;
        Console.WriteLine(nthCatalanNumber);
    }
}