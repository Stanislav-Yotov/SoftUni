using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._predicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Predicate<string> name = j => j.Length <= n;
            Console.WriteLine(string.Join("\n", names.ToList().FindAll(name)));

            
        }
    }
}
