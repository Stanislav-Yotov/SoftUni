using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string output = GetMiddleCharFromEvenSTring(input);
                Console.WriteLine(output);
            }
            else
            {
                string output = GetMiddleCharFromOddString(input);
                Console.WriteLine(output);
            }
        }

        private static string GetMiddleCharFromOddString(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleCharFromEvenSTring(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }
    }
}
