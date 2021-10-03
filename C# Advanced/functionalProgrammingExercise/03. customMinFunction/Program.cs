using System;
using System.Linq;

namespace _03._customMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getSmallestNum = numbers =>
            {
                int minValue = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(getSmallestNum(numbers));
        }
    }
}
