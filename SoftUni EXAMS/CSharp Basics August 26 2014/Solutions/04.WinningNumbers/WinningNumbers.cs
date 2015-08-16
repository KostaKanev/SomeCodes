using System;
public class WinningNumbers
{
    public static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int[] digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int letSum = 0;
        foreach (var letter in input)
        {
            letSum += letter - '`';
        }

        int winningNumsCount = 0;
        foreach (var dig1 in digits)
        {
            foreach (var dig2 in digits)
            {
                foreach (var dig3 in digits)
                {
                    if (dig1 * dig2 * dig3 == letSum)
                    {
                        foreach (var dig4 in digits)
                        {
                            foreach (var dig5 in digits)
                            {
                                foreach (var dig6 in digits)
                                {
                                    if (dig4 * dig5 * dig6 == letSum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}",
                                            dig1,dig2,dig3,dig4,dig5,dig6);
                                        winningNumsCount++; 
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (winningNumsCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}