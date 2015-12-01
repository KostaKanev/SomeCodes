using System;

public class EnterNumbers
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < 10; i++)
        {
            int number = ReadNumber(start, end);
            start = number;
        }
    }

    public static int ReadNumber(int start, int end)
    {
        string numStr = Console.ReadLine();
        int number = 0;
        
        try
        {
            number = int.Parse(numStr);
            if (number < start || number > end)
            {
                throw new OutOfRangeException(string.Format("The number must be in range from {0} to {1}", start, end));
            }
        }
        catch (Exception error)
        {
            if (error is FormatException || error is OutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine(error.Message);
            }
        }
        return number;
    } 
}