using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine()
                                       .Split()
                                       .Select(double.Parse)
                                       .ToList();

            double averageNum = 0;

            if (list.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            averageNum = list.Sum() / (double)list.Count;
            int matchingNumbersCount = list.Where(x => x > averageNum).ToArray().Count();

            if (matchingNumbersCount == 0)
            {
                Console.WriteLine("No");
            }
            else if (list.Count < 5)
            {
                Console.WriteLine("Less than 5 numbers");
            }
            else
            {
                double[] result = list.OrderByDescending(x => x).Where(x => x > averageNum).Take(5).ToArray();

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
