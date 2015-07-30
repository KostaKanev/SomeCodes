using System;
using System.Globalization;
using System.Threading;

public class BeerTime
{
    public static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        
        try
        {
            Console.Write("Please enter a time: ");
            string input = Console.ReadLine();
            DateTime time = DateTime.Parse(input);
            time.ToString("hh:mm tt");
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");

            if (time >= startTime && time <= endTime)
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("Non Beer Time");
            }    
            
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Time");
        }
    }
}