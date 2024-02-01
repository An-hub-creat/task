using System;

class SaddlePoint
{
    static void Main()
    {
        // Example matrix (replace with your own matrix)
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matrix:");
        DisplayMatrix(matrix);

        int[] saddlePoint = FindSaddlePoint(matrix);

        if (saddlePoint != null)
        {
            Console.WriteLine($"Saddle Point: {matrix[saddlePoint[0], saddlePoint[1]]}");
        }
        else
        {
            Console.WriteLine("No saddle point found.");
        }
    }

    static int[] FindSaddlePoint(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int maxInRow = int.MinValue;
            int columnIndex = -1;

            // Find the maximum element in the current row
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxInRow)
                {
                    maxInRow = matrix[i, j];
                    columnIndex = j;
                }
            }

            // Check if the maximum element in the row is also the minimum in its column
            bool isSaddlePoint = true;
            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, columnIndex] < maxInRow)
                {
                    isSaddlePoint = false;
                    break;
                }
            }

            if (isSaddlePoint)
            {
                return new int[] { i, columnIndex };
            }
        }

        return null;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
