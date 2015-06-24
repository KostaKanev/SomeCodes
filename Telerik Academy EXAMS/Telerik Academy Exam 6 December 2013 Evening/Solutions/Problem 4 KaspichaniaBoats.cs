using System;

public class KaspichaniaBoats
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int height = 6 + ((size - 3) / 2) * 3;
        int width = size * 2 + 1;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (row == size || col == size ||
                    (row == height - 1 && (col >= size / 2 && col < (size + 1) + (size / 2) )))
                {
                    Console.Write('*');
                }
                else if ( (row + col == size) || 
                    (row + col == size * 3 ))
                {
                    Console.Write('*');
                }
                else if ( (row - col == size) || 
                    (row - col == -size) )
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
