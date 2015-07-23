using System;
public class BitsExchangeAdvanced
{
    public static void Main()
    {
        //Read input from the console
        Console.Write("Enter number = ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        //Check for overlapping and out of range
        if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
        {
            Console.WriteLine("Overlapping!");
        }
        else if (p + k - 1 > 31 || q + k - 1 > 31)
        {
            Console.WriteLine("Out of range!");
        }
        else
        {
            Console.Write("Binary number before manipulation: ");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            
            for (int counter = 0; p + counter <= (p + k) - 1; counter++)
            {
                //Get bit at position 
                
                long currentBitP = getBitAtPosition(number, p + counter);
                long currentBitQ = getBitAtPosition(number, q + counter);
                
                //Set bit at position
                number = setBitAtPosition(number, currentBitP, q + counter);
                number = setBitAtPosition(number, currentBitQ, p + counter);
            }
            
            //Print the result
            Console.WriteLine("Binary number after manipulation:  {0}", Convert.ToString(number,2).PadLeft(32, '0'));
            Console.WriteLine("Decimal new number: {0}", number);
        }
    }

    //Method to get bit at given position
    public static long getBitAtPosition(long number, int position )
    {
        long mask = 1 << position;
        long numberAndMask = number & mask;
        long bit = numberAndMask >> position;
        return bit;
    }

    //Method to set bit at given position
    public static long setBitAtPosition(long number, long bit, int newPosition)
    {
        if (bit == 1)
        {
            long mask = bit << newPosition;
            number |= mask;
        }
        else
        {
            long mask = ~(1 << newPosition);
            number &= mask;
        }
        return number;
    }
}