using System;
public class AgeAfter10Years
{
    public static void Main()
    {
        //User-friendly hint.
        Console.WriteLine("Enter Birth Date in this format (MM-DD-YYYY)");
        //Enter birth day from the console.
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        
        //Calculate your age.
        Console.WriteLine("Now: {0}", DateTime.Now.Year - birthDate.Year);
        //Calculate your age after 10 years.
        Console.WriteLine("After 10 years: {0}", (DateTime.Now.Year - birthDate.Year) + 10);
    }
}