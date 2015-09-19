using System;
using System.Collections.Generic;
using System.Linq;

public class MastrixMultiplication
{
    public static int[,] matrix1;
    public static int[,] matrix2;
    public static int[,] resultMatrix;

    public static void Main()
    {

        Console.Write("Enter First Matrix Rows: ");
        int m1Rows = int.Parse(Console.ReadLine());
        Console.Write("Enter First Matrix Cols: ");
        int m1Cols = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Second Matrix Rows: ");
        int m2Rows = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Matrix Cols: ");
        int m2Cols = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (m1Cols != m2Rows)
        {
            Console.WriteLine("The matrices can't be multiplicated");
            return;
        }

        matrix1 = new int[m1Rows, m1Cols];
        for (int row = 0; row < m1Rows; row++)
        {
            for (int col = 0; col < m1Cols; col++)
            {
                Console.Write("First Matrix[{0},{1}] = ", row, col);
                matrix1[row, col] = int.Parse(Console.ReadLine());

            }
        }
        Console.WriteLine();
        matrix2 = new int[m2Rows, m2Cols];
        for (int row = 0; row < m2Rows; row++)
        {
            for (int col = 0; col < m2Cols; col++)
            {
                Console.Write("Second Matrix[{0},{1}] = ", row, col);
                matrix2[row, col] = int.Parse(Console.ReadLine());
            }
        }
        
        resultMatrix = new int[m1Rows , m2Cols];
        for (int rows = 0; rows < matrix1.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix2.GetLength(1); cols++)
            {
                for (int iterator = 0; iterator < matrix1.GetLength(1); iterator++)
                {
                    resultMatrix[rows, cols] += matrix1[rows, iterator] * matrix2[iterator, cols];
                }
            }
        }
        Console.WriteLine(new string('-',25));

        for (int row = 0; row < resultMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < resultMatrix.GetLength(1); col++)
            {
                Console.Write("{0,5}", resultMatrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}