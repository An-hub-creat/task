using System;

class Chessboard
{
    static void Main()
    {
        int[,] board = new int[8, 8];

        Console.WriteLine("Chessboard with Knight's Random Move:");

        // Place the knight on a random position
        int knightRow, knightCol;
        PlaceKnightRandomly(board, out knightRow, out knightCol);

        // Display the chessboard with the knight
        DisplayChessboard(board, knightRow, knightCol);

        // Perform a random move for the knight
        MoveKnightRandomly(board, ref knightRow, ref knightCol);

        // Display the updated chessboard with the knight's move
        DisplayChessboard(board, knightRow, knightCol);
    }

    static void PlaceKnightRandomly(int[,] board, out int row, out int col)
    {
        Random random = new Random();

        do
        {
            // Generate random coordinates for the knight
            row = random.Next(0, 8);
            col = random.Next(0, 8);
        } while (board[row, col] == 1); // Check for collisions

        // Place the knight on the chessboard
        board[row, col] = 1;
    }

    static void MoveKnightRandomly(int[,] board, ref int row, ref int col)
    {
        int[] possibleMovesRow = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] possibleMovesCol = { 1, 2, 2, 1, -1, -2, -2, -1 };

        Random random = new Random();

        int moveIndex = random.Next(possibleMovesRow.Length);

        int newRow = row + possibleMovesRow[moveIndex];
        int newCol = col + possibleMovesCol[moveIndex];

        if (IsWithinBoard(newRow, newCol) && board[newRow, newCol] == 0)
        {
            // Move the knight to the new position
            board[row, col] = 0; // Clear the previous position
            board[newRow, newCol] = 1; // Place the knight on the new position
            row = newRow;
            col = newCol;
        }
    }

    static bool IsWithinBoard(int row, int col)
    {
        return row >= 0 && row < 8 && col >= 0 && col < 8;
    }

    static void DisplayChessboard(int[,] board, int knightRow, int knightCol)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (i == knightRow && j == knightCol)
                {
                    Console.Write("K "); // Knight symbol
                }
                else
                {
                    Console.Write(board[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
