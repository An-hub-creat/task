using System;

class Chessboard
{
    static void Main()
    {
        int[,] board = new int[8, 8];

        Console.WriteLine("Randomly Placed Queens on Chessboard:");

        // Randomly place queens on the chessboard
        PlaceQueensRandomly(board);

        // Display the chessboard with queens
        DisplayChessboard(board);
    }

    static void PlaceQueensRandomly(int[,] board)
    {
        Random random = new Random();

        for (int i = 0; i < 8; i++)
        {
            int row, col;

            do
            {
                // Generate random coordinates for the queen
                row = random.Next(0, 8);
                col = random.Next(0, 8);
            } while (board[row, col] == 1); // Check for collisions

            // Place the queen on the chessboard
            board[row, col] = 1;
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
