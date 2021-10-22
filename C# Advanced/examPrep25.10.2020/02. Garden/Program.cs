using System;
using System.Linq;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = dimensions[0];
            int col = dimensions[1];
            int[,] garden = new int[row, col];
            string input;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] numbers = input.Split().Select(int.Parse).ToArray();
                int curRow = numbers[0];
                int curCol = numbers[1];

                int rowToChange = curRow;
                int colToChange = curCol;

                if (!IsPositionValid(row,col,curRow,curCol))
                {
                    while (rowToChange >= 0) //up
                    {
                        garden[rowToChange, colToChange]++;
                        rowToChange--;
                    }
                    rowToChange = curRow + 1;
                    while (rowToChange < row) //down
                    {
                        garden[rowToChange, colToChange]++;
                        rowToChange++;
                    }
                    rowToChange = curRow;
                    colToChange--;
                    while (colToChange >= 0)//left
                    {
                        garden[rowToChange, colToChange]++;
                        colToChange--;
                    }
                    colToChange = curCol + 1;
                    while (colToChange < col)//right
                    {
                        garden[rowToChange, colToChange]++;
                        colToChange++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            PrintMatrix(garden);
            
        }

        public static void PrintMatrix(int[,] garden)
        {
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    Console.Write(garden[row, col] + " ");
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
    }
}
