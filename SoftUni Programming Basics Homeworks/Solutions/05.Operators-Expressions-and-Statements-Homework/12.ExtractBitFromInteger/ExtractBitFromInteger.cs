using System;

public class ExtractBitFromInteger
{
    public static void Main()
    {
        //Read number from the console
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position for extract: ");
        int position = int.Parse(Console.ReadLine());

        //Extract the bit at position
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("The bit at position {0} is: {1}", position, bit);
    }
}
