using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            StringBuilder sb = new StringBuilder();
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance |
                BindingFlags.Static | BindingFlags.NonPublic);
            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(a => a.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (var attribute in attributes)
                    {
                        sb.AppendLine($"{method.Name} is written by {(attribute as AuthorAttribute).Name}");
                    }
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
