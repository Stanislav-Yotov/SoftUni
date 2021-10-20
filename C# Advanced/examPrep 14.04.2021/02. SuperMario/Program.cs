using System;

namespace _02._SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                field[i] = chars;
            }

            int marioRow = 0;
            int marioCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'M')
                    {
                        marioRow = i;
                        marioCol = j;
                    }
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                string[] inputArgs = input.Split();
                string command = inputArgs[0];
                int bowserRow = int.Parse(inputArgs[1]);
                int bowserCol = int.Parse(inputArgs[2]);

                lives--;
                field[bowserRow][bowserCol] = 'B';
                field[marioRow][marioCol] = '-';

                // Move
                if (command == "W" && marioRow - 1 >= 0)
                {
                    marioRow--;
                }
                else if (command == "S" && marioRow + 1 < rows)
                {
                    marioRow++;
                }
                else if (command == "A" && marioCol - 1 >= 0)
                {
                    marioCol--;
                }
                else if (command == "D" && marioCol + 1 < field[marioRow].Length)
                {
                    marioCol++;
                }

                //after moving
                if (field[marioRow][marioCol] == 'B')
                {
                    lives -= 2;
                }
                if (field[marioRow][marioCol] == 'P')
                {
                    field[marioRow][marioCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                    break;
                }
                if (lives <= 0)
                {
                    field[marioRow][marioCol] = 'X';
                    Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                    break;
                }
                field[marioRow][marioCol] = 'M';
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(field[i]));
            }
        }
    }
}
