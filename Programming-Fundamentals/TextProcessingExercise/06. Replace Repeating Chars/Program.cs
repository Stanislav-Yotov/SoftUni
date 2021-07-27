﻿using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                }
            }

            char symbol = input[input.Length - 1];
            sb.Append(symbol);

            Console.WriteLine(sb.ToString());
        }
    }
}
