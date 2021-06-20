using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Add")
                {
                    int passengers = int.Parse(cmdArgs[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(cmdArgs[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }

                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));

        }
    }
}
