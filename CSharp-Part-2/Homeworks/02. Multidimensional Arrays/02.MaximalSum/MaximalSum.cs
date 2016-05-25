using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        var rowsAndCols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        short rows = short.Parse(rowsAndCols[0]);
        short cols = short.Parse(rowsAndCols[1]);
        short[,] matrix = new short[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < line.Length; j++)
            {
                matrix[i, j] = short.Parse(line[j]);
            }
        }

        int bestSum = int.MinValue;

        for (short row = 0; row < matrix.GetLength(0) - 2; row++)     //Finding best 3x3 sum
        {
            for (short col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] 
                    + matrix[row, col + 1] 
                    + matrix[row, col + 2] 
                    + matrix[row + 1, col] 
                    + matrix[row + 1, col + 1]
                    + matrix[row + 1, col + 2] 
                    + matrix[row + 2, col] 
                    + matrix[row + 2, col + 1] 
                    + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        Console.WriteLine(bestSum);

    }
}

