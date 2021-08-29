using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            
            int s = integers[1];
            int x = integers[2];

            int[] input = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            Stack<int> stack = new Stack<int>(input);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
