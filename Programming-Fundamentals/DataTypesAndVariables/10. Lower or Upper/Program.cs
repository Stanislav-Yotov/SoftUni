using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {


            char input = char.Parse(Console.ReadLine());

            if (Char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
            else if (Char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
