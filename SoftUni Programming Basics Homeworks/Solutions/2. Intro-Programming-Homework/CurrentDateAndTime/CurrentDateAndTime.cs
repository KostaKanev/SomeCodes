using System;
public class CurrentDateAndTime
{
    public static void Main()
    {
        //Encoding for printing a Cyrillic symbols on the console.
        Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
        //Print current date and time.
        Console.WriteLine("{0:d.M.yyyy г. HH:mm:ss ч.}", DateTime.Now);
    }
}