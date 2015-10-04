using System;
using System.Text.RegularExpressions;

public class SeriesOfLetters
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"(.)\1+";
        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.Replace(text,"$1"));
    }
}