using System;
using System.Numerics;

public class Calculate
{
    public static void Main()
    {
        Console.WriteLine("Calculate N!/(K! * (N - K)!)\n");
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger NminusKfact = 1;
        
        //Calculate factorials with one loop
        for (int counter = 1; counter <= n; counter++)
        {
            nFact *= counter;

            if (counter <= k)
            {
                kFact *= counter;
            }

            if (counter <= (n - k))
            {
                NminusKfact *= counter;
            }
        }

        //Calculate and print result
        BigInteger result = nFact / (kFact * NminusKfact);
        Console.WriteLine(result);
    }
}