using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                        indexes.Push(i);
                        break;
                    case ')':
                        int index = indexes.Pop();
                        Console.WriteLine(input.Substring(index, i - index + 1));
                        break;
                }
            }
        }
    }
}
