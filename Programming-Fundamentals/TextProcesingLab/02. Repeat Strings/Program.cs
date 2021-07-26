using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split();

            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                int counter = word.Length;

                for (int i = 0; i < counter; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
