using System;
using System.Text;

public class DetectiveBoev
{
    public static void Main()
    {
        string secretWord = Console.ReadLine();
        string message = Console.ReadLine();

        int sumOfChars = 0;

        for (int i = 0; i < secretWord.Length; i++)
        {
            sumOfChars += secretWord[i];
        }
        string digitsOfSum = sumOfChars.ToString();
        int mask = 0;

        foreach (var digit in digitsOfSum)
        {
            mask += digit - '0';
        }

        while (mask >= 10)
        {
            int currenTmask = 0;
            digitsOfSum = mask.ToString();

            foreach (var digit in digitsOfSum)
            {
                 currenTmask += digit - '0';
            }
            mask = currenTmask;
        }

        StringBuilder messageBuild = new StringBuilder(message);

        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] % mask == 0)
            {
                messageBuild[i] += (char)mask;
            }
            else
            {
                messageBuild[i] -= (char)mask;
            }
        }

        for (int i = messageBuild.Length - 1; i >= 0; i--)
        {
            Console.Write(messageBuild[i]);
        }
        Console.WriteLine();
    }
}