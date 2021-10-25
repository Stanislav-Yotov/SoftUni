using System;
using System.Linq;

namespace _01._RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int curentIndex = 0;
            Console.WriteLine(Sum(arr, curentIndex, sum));
        }

        private static int Sum(int[] arr, int index, int sum)
        {
            if (index == arr.Length)
            {
                return sum;
            }
            sum += arr[index];
            index++;

            return Sum(arr, index, sum);
        }
    }
}
