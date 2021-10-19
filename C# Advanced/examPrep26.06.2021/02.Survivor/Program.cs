using System;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int beachRows = int.Parse(Console.ReadLine());
            string[][] beach = new string[beachRows][];
            for (int i = 0; i < beachRows; i++)
            {
                beach[i] = Console.ReadLine().Split();
            }

            int collectedTokens = 0;
            int oponentTokens = 0;
            string input;
            while ((input = Console.ReadLine()) != "Gong")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                if (command == "Find")
                {
                    int rowIndex = int.Parse(cmdArgs[1]);
                    int colIndex = int.Parse(cmdArgs[2]);
                    if (IsValidIndex(rowIndex, colIndex, beach))
                    {
                        if (beach[rowIndex][colIndex] == "T")
                        {
                            collectedTokens++;

                        }
                        beach[rowIndex][colIndex] = "-";
                    }
                }
                else if (command == "Opponent")
                {
                    int oponentRowIndex = int.Parse(cmdArgs[1]);
                    int oponentColIndex = int.Parse(cmdArgs[2]);
                    string direction = cmdArgs[3];
                    if (IsValidIndex(oponentRowIndex, oponentColIndex, beach))
                    {
                        oponentTokens++;

                        beach[oponentRowIndex][oponentColIndex] = "-";
                        for (int i = 0; i < 3; i++)
                        {
                            switch (direction)
                            {
                                case "up":
                                    oponentRowIndex--;
                                    break;
                                case "down":
                                    oponentRowIndex++;
                                    break;
                                case "left":
                                    oponentColIndex--;
                                    break;
                                case "right":
                                    oponentColIndex++;
                                    break;
                            }
                            if (IsValidIndex(oponentRowIndex, oponentColIndex, beach))
                            {
                                if (beach[oponentRowIndex][oponentColIndex] == "T")
                                {
                                    oponentTokens++;
                                    beach[oponentRowIndex][oponentColIndex] = "-";
                                }
                            }
                        }

                    }
                }
                //break;
            }

            for (int i = 0; i < beach.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", beach[i]));
            }

            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {oponentTokens}");
        }

        private static bool IsValidIndex(int rowIndex, int colIndex, string[][] beach)
        {
            return (rowIndex >= 0 && rowIndex < beach.GetLength(0)) &&
                   (colIndex >= 0 && colIndex < beach[rowIndex].Length);
        }
    }
}

