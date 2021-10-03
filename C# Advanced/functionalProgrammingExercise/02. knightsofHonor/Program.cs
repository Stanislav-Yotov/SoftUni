using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._knightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Sir";
            Action<List<string>> insertTitle = input => input.ForEach(x => Console.WriteLine($"Sir {x}"));

            List<string> input = Console.ReadLine().Split().ToList();
            insertTitle(input);
        }
            
    }
}
