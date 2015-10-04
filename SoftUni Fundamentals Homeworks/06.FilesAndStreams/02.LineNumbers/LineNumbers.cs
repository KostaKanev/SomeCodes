using System;
using System.IO;

public class LineNumbers
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");

        using (reader)
        {
            using (writer)
            {
                int lineNumber = 1;
                while (true)
                {
                    //Read the file line by line and print lineNumber before every single line
                    string currentLine = reader.ReadLine();
                    if (currentLine == null)
                    {
                        break;
                    }
                    writer.WriteLine("{0,5} {1}", lineNumber, currentLine);
                    lineNumber++;
                }
            }   
        }
    }
}