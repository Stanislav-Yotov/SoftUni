using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int count = 0;

            int employeeEficiency = firstEmployee + secondEmployee + thirdEmployee;

            while (peopleCount > 0)
            {
                count++;
                if (count % 4 == 0)
                {
                    continue;
                }

                peopleCount -= employeeEficiency;

            }

            Console.WriteLine($"Time needed: {count}h.");



        }
    }
}
