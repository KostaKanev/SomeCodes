using System;
public class StringsAndObjects
{
    public static void Main()
    {
        string firstString = "Hello";
        string secString = "C#";
        object concatenation = firstString + " " + secString;
        string typeCast = (string)concatenation;
        Console.WriteLine(concatenation);
        Console.WriteLine(typeCast);
    }
}