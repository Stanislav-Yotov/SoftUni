using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                      .Split()
                                      .Select(double.Parse)
                                      .ToArray();



            for (int i = 0; i < numbers.Length; i++)
            {
                int roundedNum = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                if (numbers[i] == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine($"{numbers[i]} => {roundedNum}");
            }

        }
    }
}
