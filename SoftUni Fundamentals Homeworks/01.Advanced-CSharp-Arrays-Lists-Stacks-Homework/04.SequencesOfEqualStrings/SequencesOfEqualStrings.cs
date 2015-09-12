using System;
using System.Collections.Generic;

public class SequencesOfEqualStrings
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        string currentWord = null;
        List<List<string>> lists = new List<List<string>>();
        lists.Add(new List<string>());

        for (int j = 0; j < input.Length; j++)
        {
            currentWord = input[j];
            for (int k = 0; k < lists.Count; k++)
            {
                if (lists[k].Contains(currentWord))
                {
                    lists[k].Add(currentWord);
                    break;
                }
                else if (k == lists.Count - 1)
                {
                    lists.Add(new List<string>());
                    lists[k + 1].Add(currentWord);
                    break;
                }
            }
        }
        lists.RemoveAt(0);
        foreach (var item in lists)
        {
            Console.WriteLine(string.Join(" ", item));
        }
    }
 }