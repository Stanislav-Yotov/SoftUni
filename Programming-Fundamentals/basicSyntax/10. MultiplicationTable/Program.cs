﻿using System;

namespace _10._MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = i * n;
                Console.WriteLine($"{n} X {i} = {product}");
            }
        }
    }
}
