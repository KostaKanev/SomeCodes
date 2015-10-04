using System;
using System.IO;
using System.Text.RegularExpressions;

public class WordCount
{
    public static void Main()
    {
        StreamReader wordReader = new StreamReader(@"..\..\words.txt");
        StreamWriter resultWriter = new StreamWriter(@"..\..\result.txt");

        using (wordReader)
        {
            using (resultWriter)
            {

                while (true)
                {
                    //Iterate all of words from file and searching for match with regex
                    string currentWord = wordReader.ReadLine();
                    if (currentWord == null)
                    {
                        break;
                    }
                    
                    currentWord = currentWord.ToLower();
                    string text = File.ReadAllText(@"..\..\text.txt").ToLower();
                    Regex regex = new Regex(@"\b" + currentWord + @"\b");
                    resultWriter.WriteLine("{0} - {1}", currentWord, regex.Matches(text).Count);
                    Console.WriteLine("{0} - {1}", currentWord, regex.Matches(text).Count);
                }
                Console.WriteLine("The results was saved in file result.txt in project directory !");
            }
        }
    }
}