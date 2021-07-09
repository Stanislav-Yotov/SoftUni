using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            string command = Console.ReadLine();

            int temp = 0;

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "swap")
                {

                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);

                    temp = integers[firstIndex];
                    integers[firstIndex] = integers[secondIndex];
                    integers[secondIndex] = temp;
                }
                else if (cmdArgs[0] == "multiply")
                {
                    
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);

                    integers[firstIndex] *= integers[secondIndex];
                }
                else if (command == "decrease")
                {
                    integers = Array.ConvertAll(integers, x => x - 1);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", integers));

        }
    }
}





