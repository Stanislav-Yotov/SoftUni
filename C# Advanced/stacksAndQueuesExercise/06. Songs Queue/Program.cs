using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> playList = new Queue<string>(songs);

            string command = Console.ReadLine();

            while (playList.Count > 0)
            {
                

                if (command == "Play")
                {
                    playList.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", playList));
                }
                else 
                {
                    int index = command.IndexOf(' ');
                    string song = command.Substring(index + 1);
                    if (playList.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        playList.Enqueue(song);
                    }
                }

                if (playList.Count <= 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }

                command = Console.ReadLine();
            }
        }
    }
}
