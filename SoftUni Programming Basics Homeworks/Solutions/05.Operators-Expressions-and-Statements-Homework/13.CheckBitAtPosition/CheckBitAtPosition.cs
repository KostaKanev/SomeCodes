using System;
public class CheckBitAtPosition
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

        //Chech whether the bit is one and print the result
        bool isBitOne = true ? bit == 1 : false;
        Console.WriteLine("Is bit one ? {0}", isBitOne);
    }
}