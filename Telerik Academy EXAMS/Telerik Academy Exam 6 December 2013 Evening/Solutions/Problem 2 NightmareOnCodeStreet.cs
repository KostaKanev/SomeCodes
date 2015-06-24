using System;
public class NightmareOnCodeStreet
{
    public static void Main()
    {
        string text = Console.ReadLine();

        int sumOfDigits = 0;
        int countOfDigits = 0;

        for (int i = 1; i < text.Length; i+=2)
        {
            sumOfDigits += text[i] - '0';
            countOfDigits++;
        }
        Console.WriteLine("{0} {1}" , countOfDigits , sumOfDigits );
    }
}
