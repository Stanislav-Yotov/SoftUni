using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine()
                                       .Split("|")
                                       .ToList();

            arr.Reverse();

            List<string> result = new List<string>();

            foreach (string item in arr)
            {
                string[] numbers = item
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();
                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
