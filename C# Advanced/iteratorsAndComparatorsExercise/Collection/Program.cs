﻿using System;
using System.Linq;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {

            ListIterator<string> list = null;

            string line = Console.ReadLine();

            while (line != "END")
            {
                try
                {
                    string[] commandData = line
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string command = commandData[0];

                    if (command == "Create")
                    {
                        list = new ListIterator<string>(commandData.Skip(1).ToArray());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(list.Move());
                    }
                    else if (command == "Print")
                    {
                        list.Print();
                    }
                    else if (command == "HasNext")
                    {
                        Console.WriteLine(list.HasNext());
                    }
                    else if (command == "PrintAll")
                    {
                        list.PrintAll();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                line = Console.ReadLine();
            }
        }
    }
}
