using System;
public class BonusScore
{
    public static void Main()
    {
        //Read score number from the console
        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine());
        int bonusScore = 0;

        //Check conditions
        if (score >= 1 && score <= 3)
        {
            bonusScore = score * 10;
        }
        else if (score >= 4 && score <= 6)
        {
            bonusScore = score * 100;
        }
        else if (score >= 7 && score <= 9)
        {
            bonusScore = score * 1000;
        }
        else
        {
            //If score is invalid stop program and return "Invalid score" message
            Console.WriteLine("Invalid score");
            return;
        }
        Console.WriteLine("Bonus score: " + bonusScore);
    }
}