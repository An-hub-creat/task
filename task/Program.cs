
using System;

class Chessboard
{
    static void Main()
    {
        int[,] board = new int[8, 8];

        Console.WriteLine("Chessboard with Horse Strokes:");

        // Show the horse strokes on the chessboard
        ShowHorseStrokes(board);

        // Display the chessboard
        DisplayChessboard(board);
    }

    static void ShowHorseStrokes(int[,] board)
    {
        int[,] horseMoves = { { 2, 1 }, { 1, 2 }, { -1, 2 }, { -2, 1 }, { -2, -1 }, { -1, -2 }, { 1, -2 }, { 2, -1 } };

        // Loop through each cell in the chessboard
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                // Check possible horse moves from the current cell
                foreach (var move in horseMoves)
                {
                    int nextRow = i + move[0];
                    int nextCol = j + move[1];

                    // Check if the next move is within the chessboard
                    if (nextRow >= 0 && nextRow < 8 && nextCol >= 0 && nextCol < 8)
                    {
                        // Mark the cell with a horse stroke
                        board[nextRow, nextCol] = 1;
                    }
                }
            }
        }
    }

    static void DisplayChessboard(int[,] board)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
