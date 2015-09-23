using System;
using System.Linq;

public class TextFiler
{
    public static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(new[] { ',', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
        string input = Console.ReadLine();

        Console.WriteLine(new string('-',50));
        for (int i = 0; i < bannedWords.Length; i++)
        {
            input = input.Replace(bannedWords[i],
                new string('*',bannedWords[i].Length));
        }
        Console.WriteLine(input);
    }
}