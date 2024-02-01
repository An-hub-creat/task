using System;

class Chessboard
{
    static void Main()
    {
        int[,] board = new int[8, 8];

        Console.WriteLine("Chessboard with Queen Strokes:");

        // Show the queen strokes on the chessboard
        ShowQueenStrokes(board);

        // Display the chessboard
        DisplayChessboard(board);
    }

    static void ShowQueenStrokes(int[,] board)
    {
        // Queen moves horizontally, vertically, and diagonally
        int[,] queenMoves = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 }, { 1, 1 }, { -1, -1 }, { 1, -1 }, { -1, 1 } };

        // Loop through each cell in the chessboard
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                // Check possible queen moves from the current cell
                foreach (var move in queenMoves)
                {
                    int nextRow = i + move[0];
                    int nextCol = j + move[1];

                    // Check if the next move is within the chessboard
                    while (nextRow >= 0 && nextRow < 8 && nextCol >= 0 && nextCol < 8)
                    {
                        // Mark the cell with a queen stroke
                        board[nextRow, nextCol] = 1;

                        // Move further along the current direction
                        nextRow += move[0];
                        nextCol += move[1];
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

