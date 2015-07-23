using System;
public class QuotesInStrings
{
    public static void Main()
    {
        string firstString = "The \"use\" of quotations causes difficulties.";
        string secString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(firstString);
        Console.WriteLine(secString);
    }
}