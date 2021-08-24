using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> intStack = new Stack<int>(numbers);

            string[] command = Console.ReadLine().ToLower().Split();

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    intStack.Push(int.Parse(command[1]));
                    intStack.Push(int.Parse(command[2]));

                }
                else if (command[0] == "remove")
                {
                    int n = int.Parse(command[1]);
                    if (n <= intStack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            intStack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower().Split();
            }

            Console.WriteLine($"Sum: {intStack.Sum()}");
        }
    }
}
