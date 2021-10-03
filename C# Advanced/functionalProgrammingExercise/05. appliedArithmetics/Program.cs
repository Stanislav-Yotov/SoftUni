using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._appliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> add = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += 1;
                }
            };
            Action<int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }
            };
            Action<int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }
            };
            Action<int[]> print = numbers =>
            Console.WriteLine(string.Join(" ", numbers));

            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    add(inputNums);
                }
                else if (command == "subtract")
                {
                    subtract(inputNums);
                }
                else if (command == "multiply")
                {
                    multiply(inputNums);
                }
                else if (command == "print")
                {
                    print(inputNums);
                }
                command = Console.ReadLine();
            }
        }
    }
}
