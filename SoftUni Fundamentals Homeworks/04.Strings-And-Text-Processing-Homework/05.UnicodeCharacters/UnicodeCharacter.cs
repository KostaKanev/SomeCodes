using System;

public class UnicodeCharacter
{
    public static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(string.Format("\\u{0:x4}", (int)input[i]));
        }
        Console.WriteLine();
    }
}