using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] cmdArgs = command.Split();

                switch (cmdArgs[0])
                {
                    case "Add":
                        int numToAdd = int.Parse(cmdArgs[1]);
                        numbers.Add(numToAdd);
                        break;
                    case "Remove":
                        int numToRemove = int.Parse(cmdArgs[1]);
                        numbers.Remove(numToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(cmdArgs[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(cmdArgs[1]);
                        int indexToInsert = int.Parse(cmdArgs[2]);
                        numbers.Insert(indexToInsert, numToInsert);
                        break;
                    
                }

                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
