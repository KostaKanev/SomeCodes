using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        string inputFilePath = @"..\..\inputFile.txt";
        string pattern = @"((?<=\s|^)\w+(?:[--_]\w+)*\@(?:\w+\.)*\w+)";
        
        string inputText = File.ReadAllText(inputFilePath);
        MatchCollection matches = Regex.Matches(inputText, pattern);

        //foreach (Match match in matches)
        //{
        //    Console.WriteLine(match);
        //}
        
        //System.Diagnostics.Process.Start(@"C:\Windows\system32\cmd.exe");

    }
}