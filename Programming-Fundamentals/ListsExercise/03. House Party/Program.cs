using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < input; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                if (command.Length == 3)
                {
                    if (!names.Contains(name))
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }

                }
                else
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
