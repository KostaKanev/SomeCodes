using System;

public class WiggleWiggle
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long[] numbers = new long[input.Length];
        
        long bitFirst = 0;
        long bitSec = 0;

        for (int i = 0; i < numbers.Length - 1; i+=2)
        {
            numbers[i] = long.Parse(input[i]);
            numbers[i + 1] = long.Parse(input[i + 1]);
            for (int bitIndex = 0; bitIndex < 63; bitIndex+=2)
            {
                bitFirst = GetBitAtPosition(numbers[i], bitIndex);
                bitSec = GetBitAtPosition(numbers[i + 1], bitIndex);

                numbers[i] = SetBitAtPosition(numbers[i], bitSec, bitIndex);
                numbers[i + 1] = SetBitAtPosition(numbers[i + 1], bitFirst, bitIndex);
            }
            numbers[i] = SetBitAtPosition(numbers[i], 0, 63);
            numbers[i + 1] = SetBitAtPosition(numbers[i + 1], 0, 63);

            for (int reverseIndex = 0; reverseIndex < 63; reverseIndex++)
            {
                if (GetBitAtPosition(numbers[i], reverseIndex) == 1)
                {
                    numbers[i] = SetBitAtPosition(numbers[i], 0, reverseIndex);
                }
                else if (GetBitAtPosition(numbers[i], reverseIndex) == 0)
                {
                    numbers[i] = SetBitAtPosition(numbers[i], 1, reverseIndex);
                }

                if (GetBitAtPosition(numbers[i + 1], reverseIndex) == 1)
                {
                    numbers[i + 1] = SetBitAtPosition(numbers[i + 1], 0, reverseIndex);
                }
                else if (GetBitAtPosition(numbers[i + 1], reverseIndex) == 0)
                {
                    numbers[i + 1] = SetBitAtPosition(numbers[i + 1], 1, reverseIndex);
                }
            }

            Console.WriteLine("{0} {1}", numbers[i], Convert.ToString(numbers[i], 2).PadLeft(63, '0'));
            Console.WriteLine("{0} {1}", numbers[i + 1], Convert.ToString(numbers[i + 1], 2).PadLeft(63, '0'));
        }
    }

    public static long GetBitAtPosition(long number, int bitPosition)
    {
        long mask = 1L << bitPosition;
        long numAndMask = number & mask;
        long bit = numAndMask >> bitPosition;
        return bit;
    }

    public static long SetBitAtPosition(long number, long bit, int newPosition)
    {
        if (bit == 1)
        {
            long mask = bit << newPosition;
            number = number | mask;
        }
        else
        {
            long mask = ~(1L << newPosition);
            number = number & mask;
        }
        return number;
    }
}