using System;
public class BooleanVariable
{
    public static void Main()
    {
        Console.WriteLine("Is your gender is female? yes or no");
        string answer = Console.ReadLine();
        bool isFemale = answer == "yes";
        Console.WriteLine(isFemale);  
    }
}