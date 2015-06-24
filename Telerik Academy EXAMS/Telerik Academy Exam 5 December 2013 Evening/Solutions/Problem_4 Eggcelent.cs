using System;
public class Eggcelent
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int eggHeight = 2 * size;
        int eggWidth = (3 * size) + 1;
        
        for (int row = 0; row < eggHeight; row++)
        {
            for (int col = 0; col < eggWidth; col++)
            {
                if ( (col > size && col < 2 * size) && 
                    (row == 0 || row == eggHeight - 1) )
                {
                    Console.Write('*');
                }
                else if ( (col == 1 || col == eggWidth - 2) && 
                    (row >= size / 2 && row < size * 2 - (size / 2)))
                {
                    Console.Write('*');
                }
                else if (2 * row - col == - (2 * size - 1) ||
                    (2 * row - col == (3 * size - 3)))
                {
                    Console.Write('*');
                }
                else if ((2 * row + col == size + 1) ||
                    (2 * row + col == size * 6 - 3))
                {
                    Console.Write('*');
                }
                else if ((row == size - 1 || row == size) &&
                    (col >= 2 && col < eggWidth - 1))
                {
                    if ((row == size - 1) && (col % 2 == 0))
                    {
                        Console.Write('@');
                    }
                    else if ((row == size - 1) && (col % 2 != 0))
                    {
                        Console.Write('.');
                    }
                    if ((row == size) && (col % 2 == 0))
                    {
                        Console.Write('.');
                    }
                    else if ((row == size) && (col % 2 != 0))
                    {
                        Console.Write('@');
                    }               
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
