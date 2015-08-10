using System;
public class Star
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int height = (size * 2 - (size / 2 - 1));
        int width = (2 * size + 1);

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((row >= 0 && row < size / 2) &&
                    (row + col == size || row - col == -size))
                {
                    Console.Write('*');
                }
                else if (row == size / 2)
                {
                    Console.Write("{0}{1}{0}", new string('*', size / 2 + 1), new string('.', size - 1));
                    break;
                }
                else if ((row >= size / 2 + 1 && row < size) &&
                    (row - col == size / 2 || row + col == (size * 3) - (size / 2)))
                {
                    Console.Write('*');
                }
                else if ((row >= size && row < height - 1) &&
                    (row + col == (size * 2) - (size / 2) || 
                    row - col == -size / 2 ||
                    row + col == size * 2 || 
                    row - col == 0))
                {
                    Console.Write('*');
                }
                else if (row == height - 1)
                {
                    Console.Write("{0}{1}{0}", new string('*', size / 2 + 1), new string('.', size - 1));
                    break;
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