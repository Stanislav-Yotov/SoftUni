using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int> evenNums = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());

            while (!evenNums.All(i => i % 2 == 0))
            {
                if (evenNums.Peek() % 2 == 0)
                {
                    evenNums.Enqueue(evenNums.Dequeue());
                }
                else
                {
                    evenNums.Dequeue();
                }
            }

            Console.WriteLine(string.Join(", ", evenNums.Reverse()));

        }   
    }
}
