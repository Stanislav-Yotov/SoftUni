using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string[] command = Console.ReadLine()
                                      .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                      

            bool isChanged = false;

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        int numToAdd = int.Parse(command[1]);
                        numbers.Add(numToAdd);
                        isChanged = true;
                        break;
                    case "remove":
                        int numToRemove = int.Parse(command[1]);
                        numbers.Remove(numToRemove);
                        isChanged = true;
                        break;
                    case "removeat":
                        int indexToRemove = int.Parse(command[1]);
                        numbers.RemoveAt(indexToRemove);
                        isChanged = true;
                        break;
                    case "insert":
                        int numToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);
                        numbers.Insert(indexToInsert, numToInsert);
                        isChanged = true;
                        break;
                    case "contains":
                        int containingIndex = int.Parse(command[1]);
                        Console.WriteLine(numbers.Contains(containingIndex) ? "Yes" : "No such number"); 
                        break;
                    case "printeven":
                        Console.WriteLine(string.Join(' ', numbers
                            .Where(x => x % 2 == 0)));
                        break;
                    case "printodd":
                        Console.WriteLine(string.Join(' ', numbers
                            .Where(x => x % 2 != 0)));
                        break;
                    case "getsum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "filter":
                        string result = string.Empty;
                        switch (command[1])
                        {
                            case "<":
                                result = string.Join(' ', numbers
                                    .Where(n => n < int.Parse(command[2])));
                                break;
                            case ">":
                                result = string.Join(' ', numbers
                                    .Where(n => n > int.Parse(command[2])));
                                break;
                            case "<=":
                                result = string.Join(' ', numbers
                                    .Where(n => n <= int.Parse(command[2])));
                                break;
                            case ">=":
                                result = string.Join(' ', numbers
                                    .Where(n => n >= int.Parse(command[2])));
                                break;
                        }
                        Console.WriteLine(result);
                        break;
                }

                command = Console.ReadLine()
                                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }

        }
    }
}
