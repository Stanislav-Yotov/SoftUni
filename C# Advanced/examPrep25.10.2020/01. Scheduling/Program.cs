using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int killTask = int.Parse(Console.ReadLine());
            bool isKilled = false;

            while (!isKilled)
            {
                int thread = threads.Peek();
                int task = tasks.Peek();
                if (task == killTask)
                {
                    killTask = task;
                    tasks.Pop();
                    isKilled = true;
                    break;
                }
                if (thread >= task)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (thread < task)
                {
                    threads.Dequeue();
                }

            }

            if (isKilled)
            {
                Console.WriteLine($"Thread with value {threads.Peek()} killed task {killTask}");
                Console.WriteLine(string.Join(" ", threads));
            }
        }
    }
}
