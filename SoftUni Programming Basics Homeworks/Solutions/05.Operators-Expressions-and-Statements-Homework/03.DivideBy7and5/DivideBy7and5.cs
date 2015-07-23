using System;
public class DivideBy7and5
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool isDividedBy7and5 = true ? (number % 7 == 0 && number % 5 == 0) : false;
        if (number == 0)
        {
            isDividedBy7and5 = false;
        }
        Console.WriteLine("Is divided by 7 and 5: {0}",isDividedBy7and5);
    }
}