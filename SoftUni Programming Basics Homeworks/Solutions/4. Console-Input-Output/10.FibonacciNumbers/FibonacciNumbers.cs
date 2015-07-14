using System;
public class FibonacciNumbers
{
    public static void Main()
    {
        int member = int.Parse(Console.ReadLine());

        if (member == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            int[] fibonacciNumbers = new int[member];
            Console.Write("{0} ", fibonacciNumbers[0] = 0);
            Console.Write("{0} ", fibonacciNumbers[1] = 1);

            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                Console.Write(fibonacciNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}