using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int biggestOrder = orders.Max();
            int count = orders.Count;
            for (int i = 0; i < count; i++)
            {
                if (foodQuantity >= orders.Peek())
                {
                    foodQuantity -= orders.Dequeue();
                    continue;
                }

                break;
            }
            Console.WriteLine(biggestOrder);

            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
