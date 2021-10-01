using System;
using System.Linq;

namespace _04._addVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine()
                   .Split(", ")
                   .Select(double.Parse)
                   .Select(x => x * 1.2)
                   .Select(x => $"{x:f2}")
                   .ToArray()));
        }
    }
}
