using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();
                if (cmdArgs[0] == "Add")
                {
                    int numToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numToAdd);
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int num = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.Insert(index, num);
                }
                else if (cmdArgs[0] == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (cmdArgs[1] == "left")
                {
                    int count = int.Parse(cmdArgs[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int firstElement = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstElement);
                    }
                }
                else if (cmdArgs[1] == "right")
                {
                    int count = int.Parse(cmdArgs[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int lastElement = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastElement);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));

        }
    }
}
