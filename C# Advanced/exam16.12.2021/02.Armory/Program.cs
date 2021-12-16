using System;
using System.Collections.Generic;

namespace _02.Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;

            char[,] armory = new char[rows, cols];
            int officerRow = 0;
            int officerCol = 0;
            int sum = 0;

            List<int[]> mirrors = new List<int[]>();

            for (int row = 0; row < armory.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < armory.GetLength(1); col++)
                {
                    armory[row, col] = input[col];
                    if (armory[row, col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                    }
                    if (armory[row, col] == 'M')
                    {
                        mirrors.Add(new[] { row, col });
                    }
                }
            }
            bool isInArmory = true;
            while (sum < 65)
            {
                string command = Console.ReadLine();
                armory[officerRow, officerCol] = '-';
                if (command == "up")
                {
                    if (IsValidIndex(officerRow - 1, officerCol, armory))
                    {
                        officerRow-= 1;
                        if (char.IsDigit(armory[officerRow, officerCol]))
                        {
                            sum += int.Parse(armory[officerRow, officerCol].ToString());
                        }
                        else if (armory[officerRow, officerCol] == 'M')
                        {
                            foreach (var currentMirror in mirrors)
                            {
                                int currentRow = currentMirror[0];
                                int currentCol = currentMirror[1];
                                armory[currentRow, currentCol] = '-';
                            }

                            int[] newIndexes = mirrors[1];
                            int newRow = newIndexes[0];
                            int newCol = newIndexes[1];
                            armory[newRow, newCol] = 'A';
                            officerRow = newRow;
                            officerCol = newCol;
                        }

                        armory[officerRow, officerCol] = '-';
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        isInArmory = false;
                        break;
                    }
                }

                else if (command == "down")
                {
                    if (IsValidIndex(officerRow + 1, officerCol, armory))
                    {
                        officerRow += 1;
                        if (char.IsDigit(armory[officerRow, officerCol]))
                        {
                            sum += int.Parse(armory[officerRow, officerCol].ToString());
                        }
                        else if (armory[officerRow, officerCol] == 'M')
                        {
                            foreach (var currentMirror in mirrors)
                            {
                                int currentRow = currentMirror[0];
                                int currentCol = currentMirror[1];
                                armory[currentRow, currentCol] = '-';
                            }

                            int[] newIndexes = mirrors[1];
                            int newRow = newIndexes[0];
                            int newCol = newIndexes[1];
                            armory[newRow, newCol] = 'A';
                            officerRow = newRow;
                            officerCol = newCol;
                        }

                        armory[officerRow, officerCol] = '-';
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        isInArmory = false;
                        break;
                    }
                }

                else if (command == "right")
                {
                    if (IsValidIndex(officerRow, officerCol + 1, armory))
                    {
                        officerCol += 1;
                        if (char.IsDigit(armory[officerRow, officerCol]))
                        {
                            sum += int.Parse(armory[officerRow, officerCol].ToString());
                        }
                        else if (armory[officerRow, officerCol] == 'M')
                        {
                            foreach (var currentMirror in mirrors)
                            {
                                int currentRow = currentMirror[0];
                                int currentCol = currentMirror[1];
                                armory[currentRow, currentCol] = '-';
                            }

                            int[] newIndexes = mirrors[1];
                            int newRow = newIndexes[0];
                            int newCol = newIndexes[1];
                            armory[newRow, newCol] = 'A';
                            officerRow = newRow;
                            officerCol = newCol;
                        }

                        armory[officerRow, officerCol] = '-';
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        isInArmory = false;
                        break;
                    }
                }

                else if (command == "left")
                {
                    if (IsValidIndex(officerRow, officerCol - 1, armory))
                    {
                        officerCol -= 1;
                        if (char.IsDigit(armory[officerRow, officerCol]))
                        {
                            sum += int.Parse(armory[officerRow, officerCol].ToString());
                        }
                        else if (armory[officerRow, officerCol] == 'M')
                        {
                            foreach (var currentMirror in mirrors)
                            {
                                int currentRow = currentMirror[0];
                                int currentCol = currentMirror[1];
                                armory[currentRow, currentCol] = '-';
                            }

                            int[] newIndexes = mirrors[1];
                            int newRow = newIndexes[0];
                            int newCol = newIndexes[1];
                            armory[newRow, newCol] = 'A';
                            officerRow = newRow;
                            officerCol = newCol;
                        }

                        armory[officerRow, officerCol] = '-';
                    }
                    else
                    {
                        armory[officerRow, officerCol] = '-';
                        isInArmory = false;
                        break;
                    }
                }
                armory[officerRow, officerCol] = 'A';
            }

            if (sum >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }
            else
            {
                armory[officerRow, officerCol] = '-';
                Console.WriteLine("I do not need more swords!");
            }
            Console.WriteLine($"The king paid {sum} gold coins.");
            PrintArmory(armory);
        }

        private static void PrintArmory(char[,] armory)
        {
            for (int row = 0; row < armory.GetLength(0); row++)
            {
                for (int col = 0; col < armory.GetLength(1); col++)
                {
                    Console.Write(armory[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsValidIndex(int row, int col, char[,] armory)
        {
            return row >= 0 && row < armory.GetLength(0) && col >= 0 && col < armory.GetLength(1);
        }
    }
}
