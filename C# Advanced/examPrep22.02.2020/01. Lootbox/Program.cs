using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> items = new List<int>();

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                var first = firstBox.Peek();
                var second = secondBox.Peek();
                var sum = first + second;

                if (sum % 2 == 0)
                {
                    items.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(second);
                }
            }

            if (firstBox.Count <= 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (items.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {items.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {items.Sum()}");
            }


        }
    }
}
