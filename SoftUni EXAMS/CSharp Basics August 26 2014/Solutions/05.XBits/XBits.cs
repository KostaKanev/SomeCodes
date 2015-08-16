using System;

public class XBits
{
    public static void Main()
    {
        string[] binaryNumbers = new string[8];
        for (int i = 0; i < binaryNumbers.Length; i++)
        {
            binaryNumbers[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
        }
        int xBitsCount = 0;
        for (int row = 0; row < binaryNumbers.Length - 2; row++)
        {
            for (int col = 0; col < 32 - 2; col++)
            {
                if ((binaryNumbers[row][col] == '1' && binaryNumbers[row][col + 1] == '0' && binaryNumbers[row][col + 2] == '1') &&
                    (binaryNumbers[row + 1][col] == '0' && binaryNumbers[row + 1][col + 1] == '1' && binaryNumbers[row + 1][col + 2] == '0') && 
                    (binaryNumbers[row + 2][col] == '1' && binaryNumbers[row + 2][col + 1] == '0' && binaryNumbers[row + 2][col + 2] == '1'))
                {
                    xBitsCount++;
                }
            }
        }
        Console.WriteLine(xBitsCount);
    }
}