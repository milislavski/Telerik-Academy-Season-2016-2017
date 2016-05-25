using System;

class SpiralMatrix
{
    static void PrintMatrix(int[,] matrix)
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

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int currentRow = 0;
        int currentCol = 0;
        string direction = "right";
        int endNumber = n * n;

        for (int i = 1; i <= endNumber; i++)
        {
            if (direction == "right" && (currentCol > n - 1 || matrix[currentRow, currentCol] != 0))
            {
                direction = "down";
                currentCol--;
                currentRow++;
            }
            if (direction == "down" && (currentRow > n - 1 || matrix[currentRow, currentCol] != 0))
            {
                direction = "left";
                currentRow--;
                currentCol--;
            }
            if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                direction = "up";
                currentCol++;
                currentRow--;
            }

            if (direction == "up" && currentRow < 0 || matrix[currentRow, currentCol] != 0)
            {
                direction = "right";
                currentRow++;
                currentCol++;
            }

            matrix[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            if (direction == "down")
            {
                currentRow++;
            }
            if (direction == "left")
            {
                currentCol--;
            }
            if (direction == "up")
            {
                currentRow--;
            }
        }

        PrintMatrix(matrix);
    }
}


