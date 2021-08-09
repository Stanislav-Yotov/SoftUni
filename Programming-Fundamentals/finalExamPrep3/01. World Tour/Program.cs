using System;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder destinations = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(":");

            while (command[0] != "Travel")
            {
                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string substring = command[2];

                    if (index >= 0 && index <= destinations.Length - 1)
                    {
                        destinations.Insert(index, substring);
                    }
                    Console.WriteLine(destinations);
                }

                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && startIndex <= destinations.Length - 1 && endIndex >= 0 && endIndex <= destinations.Length - 1)
                    {
                        destinations.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(destinations);
                }

                else if (command[0] == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];

                    if (destinations.ToString().Contains(oldString) && oldString != newString)
                    {
                        destinations.Replace(oldString, newString);
                    }
                    Console.WriteLine(destinations);
                }

                command = Console.ReadLine().Split(":");
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");


        }
    }
}
