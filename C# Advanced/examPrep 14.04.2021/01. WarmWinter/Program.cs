using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> set = new List<int>();

            while (hats.Count > 0 && scarfs.Count > 0)
            {
                var hat = hats.Peek();
                var scarf = scarfs.Peek();
                if (hat > scarf)
                {
                    int result = hat + scarf;
                    set.Add(result);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (scarf > hat)
                {
                    hats.Pop();
                }
                else if (hat == scarf)
                {
                    scarfs.Dequeue();
                    int result = hat + 1;
                    hats.Pop();
                    hats.Push(result);
                }
            }

            Console.WriteLine($"The most expensive set is: {set.Max()}");
            foreach (var item in set)
            {
                Console.Write(string.Join(" ", item + " "));
            }

            Console.WriteLine();
        }
    }
}
