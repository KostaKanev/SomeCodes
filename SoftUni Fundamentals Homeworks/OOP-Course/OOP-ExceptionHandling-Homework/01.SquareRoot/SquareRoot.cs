using System;

public class SquareRoot
{
    public static void Main()
    {
        string numberStr = Console.ReadLine();
        int num = 0;
        int squareRoot = 0;

        try
        {
            num = int.Parse(numberStr);
            if (num < 0)
            {
                throw new NegativeNumberException();
            }
            squareRoot = num * num;
            Console.WriteLine("Square root of number {0} = {1}", num, squareRoot);
        }
        catch (Exception error)
        {
            if (error is FormatException || 
                error is NegativeNumberException ||
                error is OverflowException)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine(error.Message);
            }
        }
        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }
}