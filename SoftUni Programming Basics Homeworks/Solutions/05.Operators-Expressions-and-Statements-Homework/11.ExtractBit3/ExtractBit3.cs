using System;

public class ExtractBit3
{
    public static void Main()
    {
        //Read number from the console
        uint number = uint.Parse(Console.ReadLine());
        
        //Extract the bit at position 3
        int position = 3;
        int mask = 1 << position;
        long numberAndMask = number & mask;
        long bit = numberAndMask >> position;
        Console.WriteLine(bit);
    }
}