using System;
using System.Linq;
using System.Collections.Generic;

public class MatrixShuffling
{
    public static void Main()
    {
        //Enter rows , cols and numbers to make Matrix
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[] numbers = new string[rows * cols];

        for (int i = 0; i < rows * cols; i++)
        {
            numbers[i] = Console.ReadLine();
        }
        string[,] matrix = MakeMatrix(rows, cols, numbers);
        
        //First read all commands from the console
        List<string[]> allCommands = new List<string[]>();
        string[] command = Console.ReadLine().Split(' ');
        while (command[0] != "END")
        {
            allCommands.Add(command);
            command = Console.ReadLine().Split(' ');
        }
        Console.WriteLine(new string('-', 25));
        //And next implement the logic to transform the matrix
        for (int counter = 0; counter < allCommands.Count; counter++)
        {
            string[] currentCommand = allCommands[counter];

            //Check for invalid input
            if (currentCommand[0] != "swap" ||
                int.Parse(currentCommand[1]) >= rows || int.Parse(currentCommand[2]) >= cols ||
                int.Parse(currentCommand[3]) >= rows || int.Parse(currentCommand[4]) >= cols)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine();
            }
            //If the check is successful swapping the elements possitions by the current command
            else
            {
                string helper = matrix[int.Parse(currentCommand[1]), int.Parse(currentCommand[2])];

                matrix[int.Parse(currentCommand[1]), int.Parse(currentCommand[2])] =
                    matrix[int.Parse(currentCommand[3]), int.Parse(currentCommand[4])];

                matrix[int.Parse(currentCommand[3]), int.Parse(currentCommand[4])] = helper;

                PrintMatrix(matrix);
                Console.WriteLine();
            }
        }
    }
    //Make integer matrix with given rows , cols and all elements
    public static string[,] MakeMatrix(int rows, int cols, string[] numbers)
    {
        string[,] result = new string[rows, cols];
        int index = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++,index++)
            {
                result[row, col] = numbers[index];
            }
        }
        return result;
    }

    //Print a matrix
    public static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}