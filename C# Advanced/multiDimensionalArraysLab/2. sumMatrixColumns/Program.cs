using System;
using System.Linq;

namespace _2._sumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                                 .Split(", ")
                                 .Select(int.Parse)
                                 .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0;  row < sizes[0];  row++)
            {
                int[] rows = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = rows[col];
                }
            }

            for (int i = 0; i < sizes[1]; i++)
            {
                int columnSum = 0;
                for (int j = 0; j < sizes[0]; j++)
                {
                    columnSum += matrix[j, i];
                }

                Console.WriteLine(columnSum);
            }
        }
    }
}
