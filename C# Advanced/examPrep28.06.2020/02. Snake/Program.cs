using System;
using System.Collections.Generic;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            int snakeRow = -1;
            int snakeCol = -1;
            List<int[]> burrows = new List<int[]>();
            for (int row = 0; row < n; row++)
            {
                var currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = currentRow[col];
                    if (field[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    if (field[row, col] == 'B')
                    {
                        burrows.Add(new int[] { row, col });
                    }
                }
            }

            int foodCounter = 0;
            string input = Console.ReadLine();
            while (true)
            {
               
                field[snakeRow, snakeCol] = '.';
                snakeRow = MoveRow(snakeRow, input);
                snakeCol = MoveCol(snakeCol, input);

                if (!IsPositionValid(snakeRow, snakeCol, n,n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (field[snakeRow, snakeCol] == '*')
                {
                    foodCounter++;
                    field[snakeRow, snakeCol] = '.';
                }
                else if (field[snakeRow, snakeCol] == 'B')
                {
                    foreach (var currentBurrow in burrows)
                    {
                        int currentRow = currentBurrow[0];
                        int currentCol = currentBurrow[1];
                        field[currentRow, currentCol] = '.';
                    }

                    int[] newIndexes = burrows[1];
                    int newRow = newIndexes[0];
                    int newCol = newIndexes[1];
                    field[newRow, newCol] = 'S';
                    snakeRow = newRow;
                    snakeCol = newCol;
                }
                field[snakeRow, snakeCol] = 'S';
                if (foodCounter >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Food eaten: {foodCounter}");

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }

        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }
    }
}
