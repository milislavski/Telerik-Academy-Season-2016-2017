using System;
using System.Collections.Generic;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string caseOfMatrix = Console.ReadLine();

        //case a
        int[,] matrixA = new int[n, n];
        int number = 1;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrixA[row, col] = number;
                number++;
            }
        }

        //case b
        int[,] matrixB = new int[n, n];

        for (int row = 0; row < matrixB.GetLength(0); row++)
        {
            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    matrixB[row, col] = (row + 1) + (col * n);
                }
                else
                {
                    matrixB[row, col] = (col + 1) * n - row;
                }
            }
        }

        //case c
        int[,] matrixC = new int[n, n];
        int currentNumber = 1;
        int end = n * n;
        int currentRow = n - 1;
        int currentCol = 0;

        for (int i = currentNumber; i <= end; i++)
        {
            matrixC[currentRow, currentCol] = currentNumber;
            currentRow++;
            currentCol++;
            currentNumber++;

            if (currentRow == n || currentCol == n)
            {
                currentRow--;
                if (currentCol == n)
                {
                    currentRow--;
                    currentCol--;
                }
                while (currentRow - 1 >= 0 && currentCol - 1 >= 0)
                {
                    currentRow--;
                    currentCol--;
                }
            }
        }

        //case d

        int[,] matrixD = new int[n, n];
        int rowD = 0;
        int colD = 0;
        string direction = "down";
        int maxNumber = n * n;

        for (int i = 1; i <= maxNumber; i++)
        {
            if (direction == "down" && (rowD > n - 1 || matrixD[rowD, colD] != 0))
            {
                direction = "right";
                rowD--;
                colD++;
            }
            if (direction == "right" && (colD > n - 1 || matrixD[rowD, colD] != 0))
            {
                direction = "up";
                colD--;
                rowD--;
            }
            if (direction == "up" && (rowD < 0 || matrixD[rowD, colD] != 0))
            {
                direction = "left";
                rowD++;
                colD--;
            }
            if (direction == "left" && (colD < 0 || matrixD[rowD, colD] != 0))
            {
                direction = "down";
                colD++;
                rowD++;
            }

            matrixD[rowD, colD] = i;

            if (direction == "down")
            {
                rowD++;
            }
            if (direction == "right")
            {
                colD++;
            }
            if (direction == "up")
            {
                rowD--;
            }
            if (direction == "left")
            {
                colD--;
            }
        }

        switch (caseOfMatrix)
        {

            case "a": PrintMatrix(matrixA); break;
            case "b": PrintMatrix(matrixB); break;
            case "c": PrintMatrix(matrixC); break;
            case "d": PrintMatrix(matrixD); break;
            default: break;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0}", matrix[row, col]);

                }

            }
            Console.WriteLine();
        }
    }
}
