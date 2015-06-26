using System;
public class Boat
{
    public static void Main()
    {
        
        int size = int.Parse(Console.ReadLine());
        int leftDots = size - 1;

        for (int i = 1; i <= size; i += 2)
        {
            Console.Write("{0}{1}{2}", new string('.', leftDots), new string('*', i), new string('.', size));
            Console.WriteLine();
            leftDots -= 2;
        }
        leftDots = 2;
        for (int i = size - 2; i >= 1; i -= 2)
        {
            Console.Write("{0}{1}{2}", new string('.', leftDots), new string('*', i), new string('.', size));
            Console.WriteLine();
            leftDots += 2;
        }
        Console.Write(new string('*', size * 2));
        Console.WriteLine();

        for (int i = 1; i < (size - 1) / 2; i++)
        {
            Console.Write("{0}{1}{0}", new string('.', i), new string('*', (size * 2) - (i * 2)));
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}
