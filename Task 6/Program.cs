using System;
using System.Collections.Generic;

class RandomMatrix
{
    static void Main()
    {
        int rows = 3; // Change this to the desired number of rows
        int cols = 4; // Change this to the desired number of columns

        int[,] matrix = GenerateRandomMatrix(rows, cols);

        Console.WriteLine("Randomly Filled Matrix:");
        DisplayMatrix(matrix);
    }

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        List<int> uniqueNumbers = GenerateUniqueNumbers(rows * cols);

        Random random = new Random();

        // Fill the matrix with random non-repeating numbers
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int index = random.Next(uniqueNumbers.Count);
                matrix[i, j] = uniqueNumbers[index];
                uniqueNumbers.RemoveAt(index);
            }
        }

        return matrix;
    }

    static List<int> GenerateUniqueNumbers(int count)
    {
        List<int> numbers = new List<int>();

        for (int i = 1; i <= count; i++)
        {
            numbers.Add(i);
        }

        return numbers;
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
