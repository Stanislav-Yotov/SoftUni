using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = PrintResult(a, b, c);
            Console.WriteLine(result);
        }

        static int PrintResult(int a, int b, int c)
        {
            int result = (a + b) - c;
            return result;
        }
    }
}
