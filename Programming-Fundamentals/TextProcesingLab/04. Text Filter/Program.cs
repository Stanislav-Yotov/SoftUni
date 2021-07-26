﻿using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string replace = new string('*', word.Length);
                text = text.Replace(word, replace);
            }

            Console.WriteLine(text);
        }
    }
}
