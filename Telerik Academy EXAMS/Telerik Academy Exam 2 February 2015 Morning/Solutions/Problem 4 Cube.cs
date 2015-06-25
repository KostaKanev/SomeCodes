using System;
public class Cube
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int helper = 0;

        Console.Write(new string(' ', size - 1));
        Console.Write(new string(':', size));
        Console.WriteLine();

        for (int i = 0; i < size - 2; i++)
        {
            helper = (size - 2) - i;
            Console.Write(new string(' ', helper));
            Console.Write(new string(':', 1));
            Console.Write(new string('/', size - 2));
            Console.Write(new string(':', 1));
            Console.Write(new string('X', i));
            Console.Write(new string(':', 1));
            Console.WriteLine();
        }

        Console.Write(new string(':', size));
        Console.Write(new string('X', size - 2));
        Console.Write(new string(':', 1));
        Console.WriteLine();

        for (int i = (size - 2) - 1; i >= 0; i--)
        {
            Console.Write(new string(':', 1));
            Console.Write(new string(' ', size - 2));
            Console.Write(new string(':', 1));
            Console.Write(new string('X', i));
            Console.Write(new string(':', 1));
            Console.WriteLine();
        }

        Console.Write(new string(':', size));
        Console.Write(new string(' ', size - 1));
        Console.WriteLine();
    }
}