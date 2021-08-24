using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> strStack = new Stack<string>(Console.ReadLine().Split().Reverse());

            while (strStack.Count > 1)
            {
                int a = int.Parse(strStack.Pop());
                string @operator = strStack.Pop();
                int b = int.Parse(strStack.Pop());

                if (@operator == "+")
                {
                    int sum = a + b;
                    strStack.Push(sum.ToString());
                }
                else
                {
                    int subtraction = a - b;
                    strStack.Push(subtraction.ToString());
                }
            }

            Console.WriteLine(strStack.Pop());
        }
    }
}
