using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputLitters = int.Parse(Console.ReadLine());
                if (sum + inputLitters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += inputLitters;
            }

            Console.WriteLine(sum);





        }
    }
}
