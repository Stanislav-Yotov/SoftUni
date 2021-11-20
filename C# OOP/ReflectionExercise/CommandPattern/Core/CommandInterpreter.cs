using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;


namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputArgs = args.Split();
            string commandName = inputArgs[0] + "Command";
            string[] param = inputArgs.Skip(1).ToArray();

            Type type = Assembly
                       .GetCallingAssembly()
                       .GetTypes()
                       .Where(t => t.Name == commandName)
                       .FirstOrDefault();

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command");
            }

            ICommand command = (ICommand)Activator.CreateInstance(type);

          
             string result = command.Execute(param);

             return result;
        }
    }
}
