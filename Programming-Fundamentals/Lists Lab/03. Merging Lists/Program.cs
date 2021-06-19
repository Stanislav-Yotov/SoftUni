using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            List<int> listTwo = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(listOne.Count, listTwo.Count); i++)
            {
                result.Add(listOne[i]);
                result.Add(listTwo[i]);
            }

            for (int i = Math.Min(listOne.Count, listTwo.Count); i < Math.Max(listOne.Count, listTwo.Count); i++)
            {
                if (i >= listOne.Count)
                {
                    result.Add(listTwo[i]);
                }
                else
                {
                    result.Add(listOne[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));

        }
    }
}
