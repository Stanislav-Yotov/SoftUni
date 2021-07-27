using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string lastFile = input[input.Length - 1];
            string[] arr = lastFile.Split(".");

            string file = arr[0];
            string extension = arr[1];

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
