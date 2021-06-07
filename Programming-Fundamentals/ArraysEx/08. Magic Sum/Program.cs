using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int firstNum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secondNum = arr[j];
                    if (firstNum + secondNum == magicNum)
                    {
                        Console.WriteLine($"{firstNum} {secondNum}");
                    }
                }
            }
        }
    }
}
