using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Stack<char> charStack = new Stack<char>(Console.ReadLine().ToCharArray());

            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }

            Console.WriteLine();

        }
    }
}
