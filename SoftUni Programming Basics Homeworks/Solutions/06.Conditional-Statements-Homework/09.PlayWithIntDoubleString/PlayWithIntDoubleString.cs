using System;
public class PlayWithIntDoubleString
{
    public static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1--> Int");
        Console.WriteLine("2--> Double");
        Console.WriteLine("3--> String");
        Console.Write("\nYour choice: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter a integer: ");
                int integer = int.Parse(Console.ReadLine());
                integer++;
                Console.WriteLine("Your result: " + integer);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber++;
                Console.WriteLine("Your result: " + doubleNumber);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string inputStr = Console.ReadLine() + "*";
                Console.WriteLine("Your result: " + inputStr);
                break;
        }
    }
}