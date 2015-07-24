using System;
public class Volleyball
{
    public static void Main()
    {
        //Read input from the console
        string leapOrNormal = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());

        //Calculate plays
        int hometownPlays = hometownWeekends;
        double normalWeekendPlays = (48 - hometownPlays) * (3.0 / 4);
        double holidayPlays = holidays * (2.0 / 3);

        double allPlays = hometownPlays + normalWeekendPlays + holidayPlays;

        if (leapOrNormal == "leap")
        {
           allPlays = allPlays + allPlays * 0.15;
        }

        Console.WriteLine(Math.Floor(allPlays));
    }
}