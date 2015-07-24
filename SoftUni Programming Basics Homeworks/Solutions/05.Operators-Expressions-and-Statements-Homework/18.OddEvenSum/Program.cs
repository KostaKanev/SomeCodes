using System;

class OddEvenSum
{
    static void Main()
    {
        Console.Write("Enter count of odd and even numbers: ");
        int number = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 1; i <= number * 2; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            if (i % 2 != 0)
            {
                oddSum += currentNumber;
            }
            else
            {
                evenSum += currentNumber;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum=" + oddSum);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(evenSum - oddSum));
        }
    }
}