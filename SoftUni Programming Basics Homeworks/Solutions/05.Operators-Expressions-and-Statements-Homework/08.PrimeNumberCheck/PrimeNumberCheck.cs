using System;
public class PrimeNumberCheck
{
    public static void Main()
    {
        //Read number from the console
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        //Make array with the prime number to 100
        int[] primes = new int[] {
            2, 3, 5, 7, 11, 13, 17,
            19, 23, 29, 31, 37, 41,
            43, 47, 53, 59, 61, 67,
            71, 73, 79, 83, 89, 97
        };

        //Check whether the number is in the primes array and print the result
        bool isPrimer = false;
        for (int i = 0; i < primes.Length; i++)
        {
            if (number.Equals(primes[i]))
            {
                isPrimer = true;
                break;
            }
        }
        Console.WriteLine("Is number a Prime? {0}", isPrimer);
    }
}