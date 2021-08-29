using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesBox = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothesBox);
            int counter = 1;
            int currentClothes = 0;

            while (stack.Count > 0)
            {
                if (currentClothes + stack.Peek() > rackCapacity)
                {
                    currentClothes = 0;
                    counter++;
                }
                currentClothes += stack.Pop();
            }
            Console.WriteLine(counter);
        }
    }
}
