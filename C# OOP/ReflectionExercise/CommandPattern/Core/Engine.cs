﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Contracts
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string result = commandInterpreter.Read(input);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
