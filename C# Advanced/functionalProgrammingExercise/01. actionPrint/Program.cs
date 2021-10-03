using System;

namespace _01._actionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printCollection = input => Console.WriteLine(string.Join("\n", input));

            string[] input = Console.ReadLine().Split();
            printCollection(input);
        }
    }
}
