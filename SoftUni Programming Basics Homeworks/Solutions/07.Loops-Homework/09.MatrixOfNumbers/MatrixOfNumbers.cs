using System;
public class MatrixOfNumbers
{
    public static void Main()
    {
        Console.Write("Please enter size of matrix: ");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize,matrixSize];
        
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                matrix[row, col] = (row + col) + 1;
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}