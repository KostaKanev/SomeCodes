using System;

public class PrintDeckOf52Cards
{
    public static void Main()
    {
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9","10", "J", "Q", "K", "A" };
        char club = '\u2663';
        char diamond = '\u2666';
        char heart = '\u2665';
        char spade = '\u2660';

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0: Console.Write(cards[i] + club + ' '); break;
                    case 1: Console.Write(cards[i] + diamond + ' '); break;
                    case 2: Console.Write(cards[i] + heart + ' '); break;
                    case 3: Console.Write(cards[i] + spade + ' '); break;
                }
            }
            Console.WriteLine();
        }
    }
}