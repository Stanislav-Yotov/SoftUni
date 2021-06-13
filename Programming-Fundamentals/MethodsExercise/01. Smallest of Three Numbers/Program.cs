using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = SmallestInt(a, b, c);
            Console.WriteLine(result);

        }

        static int SmallestInt(int a, int b, int c)
        {
            int result = Math.Min(a, Math.Min(b, c));
            return result;
        }
    }
}
