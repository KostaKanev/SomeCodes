using System;

class Cube
{
    static void Main()
    {
        int n = 5; // int.Parse(Console.ReadLine());

        Console.Write(new string(' ', n - 1));
        Console.Write(new string(':', n));
        Console.Write(new string(' ', n - 2));
        Console.WriteLine();
        Console.Write(new string(' ', n - 2));
        Console.Write(':');
        Console.Write(new string('/', n - 2));
        Console.Write(new string(':', 2));
        Console.WriteLine();

        for (int i = 0; i < n - 3; i++)
        {
            Console.Write(new string(' ', ((n - 3) - i)));
            Console.Write(':');
            Console.Write(new string('/', n - 2));
            Console.Write(':');
            Console.Write(new string('X', (i + 1)));
            Console.Write(':');
            Console.WriteLine();
        }

        Console.Write(new string(':', n));
        Console.Write(new string('X', n - 2));
        Console.Write(':');
        Console.WriteLine();

        for (int i = 0; i < n - 3; i++)
        {
            Console.Write(':');
            Console.Write(new string(' ', n - 2));
            Console.Write(':');
            Console.Write(new string('X', ((n - 3) - i)));
            Console.Write(':');
            Console.WriteLine();
        }

        Console.Write(':');
        Console.Write(new string(' ', n - 2));
        Console.Write(new string(':', 2));
        Console.WriteLine();
        Console.Write(new string(':', n));
        Console.WriteLine();
    }
}