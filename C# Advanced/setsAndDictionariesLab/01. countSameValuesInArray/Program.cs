using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._countSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();

            foreach (var num in n)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers[num] = 1;
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }

        }
    }
}
