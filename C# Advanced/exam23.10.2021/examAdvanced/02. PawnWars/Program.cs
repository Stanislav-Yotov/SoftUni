using System;

namespace _02._PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] chessBoard = new char[8, 8];
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    chessBoard[i, j] = row[j];
                }
            }

            int whiteRow = 0;
            int whiteCol = 0;
            int blackRow = 0;
            int blackCol = 0;

            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    if (chessBoard[i, j] == 'w')
                    {
                        whiteRow = i;
                        whiteCol = j;
                    }
                    if (chessBoard[i, j] == 'b')
                    {
                        blackRow = i;
                        blackCol = j;
                    }
                }
            }

            int counter = 0;

            while (true)
            {
                if (counter % 2 == 0)
                {
                    if (IsPositionValid(chessBoard, whiteRow - 1, whiteCol - 1))
                    {
                        if (chessBoard[whiteRow - 1, whiteCol - 1] == 'b')
                        {
                            Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}{8 - blackRow}.");
                            return;
                        }
                    }
                    if (IsPositionValid(chessBoard, whiteRow - 1, whiteCol + 1))
                    {
                        if (chessBoard[whiteRow - 1, whiteCol + 1] == 'b')
                        {
                            Console.WriteLine($"Game over! White capture on {(char)(blackCol + 97)}{8 - blackRow}.");
                            return;
                        }
                    }
                    chessBoard[whiteRow, whiteCol] = '-';
                    whiteRow--;
                    if (whiteRow == 0)
                    {
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(whiteCol + 97)}{8 - whiteRow}.");
                        return;
                    }
                    chessBoard[whiteRow, whiteCol] = 'w';
                }

                else
                {
                    if (IsPositionValid(chessBoard, blackRow + 1, blackCol + 1))
                    {
                        if (chessBoard[blackRow + 1, blackCol + 1] == 'w')
                        {
                            Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}{8 - whiteRow}.");
                            return;
                        }
                    }
                    if (IsPositionValid(chessBoard, blackRow + 1, blackCol - 1))
                    {
                        if (chessBoard[blackRow + 1, blackCol - 1] == 'w')
                        {
                            Console.WriteLine($"Game over! Black capture on {(char)(whiteCol + 97)}{8 - whiteRow}.");
                            return;
                        }
                    }
                    chessBoard[blackRow, blackCol] = '-';

                    blackRow++;
                    if (blackRow == 7)
                    {
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(blackCol + 97)}{8 - blackRow}.");
                        return;
                    }
                    chessBoard[blackRow, blackCol] = 'b';
                }
                counter++;
            }

        }

        public static bool IsPositionValid(char[,] field, int row, int col)
        {
            if (row < 0 || row > field.GetLength(0))
            {
                return false;
            }
            if (col < 0 || col > field.GetLength(1))
            {
                return false;
            }

            return true;
        }

        public static int WhiteMove(int row)
        {
            return row - 1;
        }

        public static int BlackMove(int row)
        {
            return row + 1;
        }
    }
}

