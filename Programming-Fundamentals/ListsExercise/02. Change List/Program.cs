using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                if (cmdArgs[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(cmdArgs[1]));
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int numToInsert = int.Parse(cmdArgs[1]);
                    int indexToInsert = int.Parse(cmdArgs[2]);
                    numbers.Insert(indexToInsert, numToInsert);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
