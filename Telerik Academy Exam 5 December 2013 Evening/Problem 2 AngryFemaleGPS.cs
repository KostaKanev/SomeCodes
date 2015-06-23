using System;
public class AngryFemaleGPS
{
    public static void Main()
    {
        
        string numberToString = Console.ReadLine();
        int oddSum = 0;
        int evenSum = 0;
        
      
        for (int i = 0; i < numberToString.Length; i++)
        {
            if ( (numberToString[i] - '0') % 2 == 0)
            {
                evenSum += numberToString[i] - '0';
            }
            else
            {
                oddSum += numberToString[i] - '0';
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("straight {0}", oddSum);
        }
        else if (oddSum > evenSum)
        {
            Console.WriteLine("left {0}" , oddSum);
        }
        else
        {
            Console.WriteLine("right {0}" , evenSum);
        }
    }
}

