using System;

public class TwoFourEight
{
    public static void Main()
    {
        // read input from console
        int numberA = int.Parse(Console.ReadLine());
        int numberB = int.Parse(Console.ReadLine());
        int numberC = int.Parse(Console.ReadLine());

        
        int result = 0;
        // check for numberB if == 2 || 4 || 8
        if (numberB == 2)
        {
            result = numberA % numberC;
        }
        else if (numberB == 4)
        {
            result = numberA + numberC;
        }
        else if (numberB == 8)
        {
            result = numberA * numberC;
        }

        // check for result divided by 4
        if (result % 4 == 0)
        {
            Console.WriteLine(result / 4);
        }
        else
        {
            Console.WriteLine(result % 4);
        }
        Console.WriteLine(result);
    }
}

