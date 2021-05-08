using System;

namespace _05.divideWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{1.0 * p1 / n * 100:f2}%");
            Console.WriteLine($"{1.0 * p2 / n * 100:f2}%");
            Console.WriteLine($"{1.0 * p3 / n * 100:f2}%");


        }
    }
}
