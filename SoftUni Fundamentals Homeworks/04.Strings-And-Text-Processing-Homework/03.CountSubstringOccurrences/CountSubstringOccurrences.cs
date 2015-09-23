using System;

public class ProgrCountSubstringOccurrencesam
{
    public static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string str = Console.ReadLine().ToLower();
        int currentIndex = 0;
        int countOfIndexes = 0;
        while (input.IndexOf(str,currentIndex) != -1)
        {
            currentIndex = input.IndexOf(str,currentIndex) + 1;
            countOfIndexes++;
        }
        Console.WriteLine(countOfIndexes);
    }
}