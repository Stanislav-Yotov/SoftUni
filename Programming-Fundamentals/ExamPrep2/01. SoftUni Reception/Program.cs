using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int counter = 0;
            int employeeEficiency = firstEmployee + secondEmployee + thirdEmployee;

            while (peopleCount > 0)
            {
                counter++;
                if (counter % 4 == 0)
                {
                    continue;
                }

                peopleCount -= employeeEficiency;
            }

            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
