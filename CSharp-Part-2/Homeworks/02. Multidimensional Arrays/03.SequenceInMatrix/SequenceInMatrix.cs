using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{
    static void Main()
    {
        var rowAndCols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var rows = int.Parse(rowAndCols[0]);
        var cols = int.Parse(rowAndCols[1]);

        string[,] matrix = new string[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < line.Length; j++)
            {
                matrix[i, j] = line[j];
            }
        }

        int bestSequence = 0;


        for (int row = 0; row < matrix.GetLength(0); row++)
        {

            string currentElement = "";
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentSequence = 0;
                currentSequence += Right(matrix, row, col, matrix[row, col]);
                currentSequence += Left(matrix, row, col, matrix[row, col]);
                currentSequence += RightDiagonal(matrix, row, col, matrix[row, col]);
                currentSequence += LeftDiagonal(matrix, row, col, matrix[row, col]);
                currentSequence += Down(matrix, row, col, matrix[row, col]);
                currentElement = matrix[row, col];
                currentSequence++;

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                }
            }
        }

        Console.WriteLine(bestSequence);
    }

    private static int LeftDiagonal(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        row--;
        col--;
        while (true)
        {
            if (col < 0 ||
                row < 0)
            {
                break;
            }
            if (matrix[row, col] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
            row--;
            col--;
        }
        return result;
    }

    private static int Left(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        for (int i = col + 1; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
        }
        return result;
    }

    private static int Right(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        for (int i = col - 1; i >= 0; i--)
        {
            if (matrix[row, i] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
        }
        return result;
    }

    private static int RightDiagonal(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        row++;
        col++;
        while (true)
        {
            if (col == matrix.GetLength(1) ||
                row == matrix.GetLength(0))
            {
                break;
            }
            if (matrix[row, col] == searchElement)
            {
                result++;
            }
            else
            {
                break;
            }
            row++;
            col++;
        }
        return result;
    }

    private static int Down(string[,] matrix, int row, int col, string searchElement)
    {
        int result = 0;
        if (row != matrix.GetLength(0) - 1)
        {
            for (int i = row + 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, col] == searchElement)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
        }
        return result;
    }
}

