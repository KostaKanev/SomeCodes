using System;
public class ModifyBitAtPosition
{
    public static void Main()
    {
        //Read input from console
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int bit = int.Parse(Console.ReadLine());

        //Check whether the readed bit is 0 or 1 and put it to position
        if (bit == 1)
        {
            int mask = bit << position;
            number |= mask;
        }
        else
        {
            int mask = ~(1 << position);
            number &= mask;
        }
        Console.WriteLine(number); 
    }
}