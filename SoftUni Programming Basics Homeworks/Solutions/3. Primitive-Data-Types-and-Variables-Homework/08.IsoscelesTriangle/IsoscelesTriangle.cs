using System;
public class IsoscelesTriangle
{
    public static void Main()
    {
        char copyRight = '\u00A9';

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 7; col++)
            {
                if (row == 3 && col % 2 == 0)
                {
                    Console.Write(copyRight);
                }
                else if (row + col == 3)
                {
                    Console.Write(copyRight);
                }
                else if (row - col == -3)
                {
                    Console.Write(copyRight);
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