using System;
public class CheatSheet
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long startRow = int.Parse(Console.ReadLine());
        long startCol = int.Parse(Console.ReadLine());

        for (long row = startRow; row < startRow + rows; row++)
        {
            for (long col = startCol; col < startCol + cols; col++)
            {
                Console.Write(row * col);
                if (col < startCol + cols - 1)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
