using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();


            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!chars.ContainsKey(letter))
                    {
                        chars.Add(letter, 0);
                    }
                    chars[letter]++;
                }
            }

            foreach (var c in chars)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
