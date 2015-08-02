using System;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Calculate Odd And Even Product\n");
        Console.WriteLine("Please enter numbers separated by ' ' ");
        string[] inputLine = Console.ReadLine().Split();

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 1; i <= inputLine.Length; i++)
        {
            if (i % 2 != 0)
            {
                oddProduct *= int.Parse(inputLine[i - 1]);
            }
            else
            {
                evenProduct *= int.Parse(inputLine[i - 1]);
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes\nProduct = {0}",oddProduct);
        }
        else
        {
            Console.WriteLine("No\nOdd product = {0}\nEven product = {1}", oddProduct, evenProduct);
        }
    }
}