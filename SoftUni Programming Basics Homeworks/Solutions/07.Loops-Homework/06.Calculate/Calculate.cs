using System;
using System.Numerics;

public class Calculate
{
    public static void Main()
    {
        Console.WriteLine("Calculate N!/K!\n");
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        
        //Calculate factorials
        for (int counter = 1; counter <= n; counter++)
        {
            nFact *= counter;

            if (counter <= k)
            {
                kFact *= counter;
            }
        }

        //Calculate and print result
        BigInteger result = nFact / kFact;
        Console.WriteLine(result);
    }
}