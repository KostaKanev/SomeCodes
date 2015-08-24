using System;

public class SummerTimeForProgrammers
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int width = 2 * size;
        int height = 3 * size + 1;
        
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (row == 0 && col >= size / 2 && col <= (size / 2) + size)
                {
                    Console.Write('*');
                }
                else if ((col == size / 2 || col == size + (size / 2)) && row <= size / 2)
                {
                    Console.Write('*');
                }
                else if (row + col == size  && row >= size / 2 + 1)
                {
                    Console.Write('*');
                }
                else if (row - col == -(size - 1) && row >= size / 2 + 1)
                {
                    Console.Write('*');
                }
                else if ((col == 0 || col == width - 1) && row > size)
                {
                    Console.Write('*');
                }
                else if (row >= size && row < size * 2)
                {
                    Console.Write('.');
                }
                else if (row >= size * 2 && row < height - 1)
                {
                    Console.Write('@');
                }
                else if (row == height - 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}