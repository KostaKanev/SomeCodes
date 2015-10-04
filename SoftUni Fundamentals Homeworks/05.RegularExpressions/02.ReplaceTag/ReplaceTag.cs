using System;
using System.IO;
using System.Text.RegularExpressions;

public class ReplaceTag
{
    public static void Main()
    {
        string inputFilePath = @"..\..\inputHTML.html";
        string outputFilePath = @"..\..\outputHTML.html";
        string htmlText = File.ReadAllText(inputFilePath);
        string pattern = @"<a(.+href=)\W(\w+:\/\/\w+.\w+)\W>([A-Za-z\d\W]+)<\/a>";

        Console.WriteLine("INPUT\n{0}\n{1}", new string('-',30), htmlText);
        
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            writer.WriteLine(Regex.Replace(htmlText, pattern, @"[URL$1$2]$3[/URL]"));
        }
        Console.WriteLine();
        Console.WriteLine("OUTPUT\n{0}\n{1}", new string('-', 30), File.ReadAllText(outputFilePath));
    }
}   