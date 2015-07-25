using System;
public class PlayCardCheck
{
    public static void Main()
    {
        string card = Console.ReadLine();

        if ((int.Parse(card) >= 2 && int.Parse(card) <= 10) || 
            (card == "J" ||
            card == "Q" ||
            card == "K" ||
            card == "A"))
        {
            Console.WriteLine("yes");
            return;
        }
        Console.WriteLine("no");
    }
}