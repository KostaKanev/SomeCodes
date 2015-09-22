using System;
using System.Linq;

public class MaximalSum
{
    public static void Main()
    {
        //Enter numbers for rows and cols of the matrix
        Console.Write("Please enter number of Rows: ");
        int rowsOfMatrix = int.Parse(Console.ReadLine());
        Console.Write("Please enter number of Cols: ");
        int colsOfMatrix = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rowsOfMatrix, colsOfMatrix];

        //Fill the matrix with input numbers
        for (int row = 0; row < rowsOfMatrix; row++)
        {
            string[] currentLine = Console.ReadLine().Split();
            for (int col = 0; col < colsOfMatrix; col++)
            {
                matrix[row, col] = int.Parse(currentLine[col]);
            }
        }

        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        //Searching for best 3x3 platform sum
        for (int row = 0; row < rowsOfMatrix - 2; row++)
        {
            for (int col = 0; col < colsOfMatrix - 2; col++)
            {
                int currentSum = 0;
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        //Make submatrix platform and printing it
        int[,] resultSubMatrix =
        {
            { matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2] },
            { matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2] },
            { matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2] }
        };

        Console.WriteLine("Best 3x3 SubMatrix is:");
        PrintMatrix(resultSubMatrix);
        
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}