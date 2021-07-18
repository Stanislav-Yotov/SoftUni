using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            Dictionary<string, string> database = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] cmdArgs = command.Split();
                
                
                if (cmdArgs[0] == "register")
                {
                    if (!database.ContainsKey(cmdArgs[1]))
                    {
                        database.Add(cmdArgs[1], cmdArgs[2]);
                        Console.WriteLine($"{cmdArgs[1]} registered {cmdArgs[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {cmdArgs[2]}");
                    }
                }
                else if (cmdArgs[0] == "unregister")
                {
                    if (database.ContainsKey(cmdArgs[1]))
                    {
                        database.Remove(cmdArgs[1]);
                        Console.WriteLine($"{cmdArgs[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {cmdArgs[1]} not found");
                    }
                }
            }

            foreach (var user in database)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
