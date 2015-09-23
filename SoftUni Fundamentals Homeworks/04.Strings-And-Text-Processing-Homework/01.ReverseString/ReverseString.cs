using System;
using System.Text;
public class ReverseString
{
    public static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        StringBuilder reversedInput = new StringBuilder();
        reversedInput.Length = input.Length;
        for (int i = 0; i < input.Length; i++)
        {
            reversedInput[i] = input[input.Length - i - 1];
        }
        Console.WriteLine("Reversed input: {0}", reversedInput);
    }
}