using System;
using System.Linq;

public class FillTheMatrix
{
    public static void Main()
    {
        Console.Write("Please enter number for rows and columns of the matrix: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[,] firstMatrix = MakeMatrixFromBotRight(size);
        int[,] secondMatrix = MakeMatrixFromUpRight(size);
        Console.WriteLine("Matrix filled from bottom to top and right to left");
        PrintMatrix(firstMatrix);
        Console.WriteLine();
        Console.WriteLine("Matrix filled from top to bottom and right to left");
        PrintMatrix(secondMatrix);
    }

    public static int[,] MakeMatrixFromBotRight(int size)
    {
        int[,] resultMatrix = new int[size, size];
        int counter = size * size;
        for (int col = size - 1; col >= 0; col--)
        {
            for (int row = size - 1; row >= 0; row--, counter--)
            {
                resultMatrix[row, col] = counter;
            }
        }
        return resultMatrix;
    }

    public static int[,] MakeMatrixFromUpRight(int size)
    {
        int[,] resultMatrix = new int[size, size];
        int counter = size * size;

        for (int col = size - 1; col >= 0; col--)
        {
            if (col % 2 != 0)
            {
                for (int row = 0; row < size; row++, counter--)
                {
                    resultMatrix[row, col] = counter;
                }
            }
            else
            {
                for (int row = size - 1; row >= 0; row--,counter--)
                {
                    resultMatrix[row, col] = counter;
                }
            }
        }
        return resultMatrix;
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