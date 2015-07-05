using System;
public class FunWithMatrices
{
    public static void Main(string[] args)
    {
        double startNum = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        
        //TODO - Make the matrix with values
        double[,] matrix = new double[4, 4];

        for (int row = 0 , index = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++, index++)
            {
                matrix[row, col] = startNum + (index * step);
            }
        }
        string input = Console.ReadLine();
        string[] command = input.Split(' ');
        
        //TODO - Changes by commands
        while (input != "Game Over!")
        {
            if (command[2].Contains("sum"))
            {
                matrix[int.Parse(command[0]),int.Parse(command[1])] += double.Parse(command[3]);
            }
            else if (command[2].Contains("multiply"))
            {
                matrix[int.Parse(command[0]), int.Parse(command[1])] *= double.Parse(command[3]);
            }
            else if (command[2].Contains("power"))
            {
                matrix[int.Parse(command[0]), int.Parse(command[1])] =
                    Math.Pow(matrix[int.Parse(command[0]), int.Parse(command[1])], double.Parse(command[3]));
            }

            input = Console.ReadLine();
            command = input.Split(' ');
        }

        //TODO - Best row,col and left,right diagonals
        
            // best row check
        double currentValue = 0;
        int currentRowIndex = 0;
        double rowSum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentValue += matrix[row, col];
            }

            if (currentValue > rowSum)
            {
                rowSum = currentValue;
                currentRowIndex = row;
            }
            currentValue = 0;
        }
        
            // best col check
        double colSum = 0;
        int currentColIndex = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currentValue += matrix[row, col];
            }

            if (currentValue > colSum)
            {
                colSum = currentValue;
                currentColIndex = col;
            }
            currentValue = 0;
        }

            // right diagonal check
        double rightDiagonal = 0;
        for (int row = 0,col = 0; row < matrix.GetLength(0); row++, col++)
        {
            rightDiagonal += matrix[row, col];
        }

            // left diagonal check

        double leftDiagonal = 0;
        for (int row = 3 , col = 0; col < matrix.GetLength(0); row--, col++)
        {
            leftDiagonal += matrix[row, col];
        }

        //Check ALL sums
        
        double result = rowSum;
        string stringResult = "ROW[" + currentRowIndex + "] = ";

        if (colSum > result)
        {
            result = colSum;
            stringResult = "COLUMN[" + currentColIndex  + "] = ";
        }
        if (leftDiagonal > result)
        {
            result = leftDiagonal;
            stringResult = "LEFT-DIAGONAL = ";
        }
        if (rightDiagonal > result)
        {
            result = rightDiagonal;
            stringResult = "RIGHT-DIAGONAL = ";
        }

        Console.WriteLine("{0}{1:F2}",stringResult , result);
    }
}
