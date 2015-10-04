using System;
using System.IO;


public class OddLines
{
    public static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        using (reader)
        {
            int numberOfLine = 1;
            while (true)
            {
                //Check if current number of line is odd
                //and print it to the console.
                if (numberOfLine % 2 != 0)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                    numberOfLine++;
                }
                //Else skip the line
                else
                {
                    reader.ReadLine();
                    numberOfLine++;
                }
            }
        }
    }
}