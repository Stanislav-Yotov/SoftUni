using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._reverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> num = x => x % n != 0;
            Console.WriteLine(string.Join(" ", numbers.FindAll(num)));
        }
    }
}
