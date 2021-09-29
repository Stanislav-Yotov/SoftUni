using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._setsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<string> first = new HashSet<string>();
            HashSet<string> second = new HashSet<string>();

            for (int i = 0; i < nums[0]; i++)
            {
                first.Add(Console.ReadLine());
            }

            for (int i = 0; i < nums[1]; i++)
            {
                second.Add(Console.ReadLine());
            }

            first.IntersectWith(second);
            Console.WriteLine(string.Join(" ", first));
        }
    }
}
