using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                                               .Split("!")
                                               .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] cmdArgs = command.Split();
                if (cmdArgs[0] == "Urgent")
                {
                    if (!shoppingList.Contains(cmdArgs[1]))
                    {
                        shoppingList.Insert(0, cmdArgs[1]);
                    }
                    
                }
                else if (cmdArgs[0] == "Unnecessary")
                {
                    if (shoppingList.Contains(cmdArgs[1]))
                    {
                        shoppingList.Remove(cmdArgs[1]);
                    }
                    
                }
                else if (cmdArgs[0] == "Correct")
                {
                    string newGrocerie = cmdArgs[2];
                    int index = shoppingList.IndexOf(cmdArgs[1]);
                    if (shoppingList.Contains(cmdArgs[1]))
                    {
                        shoppingList.Insert(index, newGrocerie);
                        shoppingList.Remove(cmdArgs[1]);
                    }
                }
                else if (cmdArgs[0] == "Rearrange")
                {
                    if (shoppingList.Contains(cmdArgs[1]))
                    {
                        shoppingList.Remove(cmdArgs[1]);
                        shoppingList.Add(cmdArgs[1]);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
