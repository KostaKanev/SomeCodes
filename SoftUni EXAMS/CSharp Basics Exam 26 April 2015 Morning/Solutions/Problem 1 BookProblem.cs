using System;
public class BookProblem
{
    public static void Main()
    {
        int numberOfPages = int.Parse(Console.ReadLine());
        int campignDays = int.Parse(Console.ReadLine());
        int readPerDay = int.Parse(Console.ReadLine());

        if (numberOfPages < readPerDay || campignDays == 30 || readPerDay == 0)
        {
            Console.WriteLine("never");
            return;
        }
        
        int daysPerMonth = 30 - campignDays;
        
        int pagesPerMonth = daysPerMonth * readPerDay;
        int allMonths = (int)Math.Ceiling((double)numberOfPages / pagesPerMonth);
        
        int years = allMonths / 12;
        int months = allMonths % 12;
        Console.WriteLine("{0} years {1} months", years, months);
    }
}
