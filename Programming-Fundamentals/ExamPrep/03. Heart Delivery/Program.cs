using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neededHearts = Console.ReadLine()
               .Split("@")
               .Select(int.Parse)
               .ToList();

            string input = Console.ReadLine();
            int currentPossition = 0;
            while (input != "Love!")
            {
                List<string> inputArg = input
                    .Split()
                    .ToList();
                currentPossition += int.Parse(inputArg[1]);

                if (currentPossition > neededHearts.Count - 1)
                {
                    currentPossition = 0;
                }
                if (neededHearts[currentPossition] == 0)
                {
                    Console.WriteLine($"Place {currentPossition} already had Valentine's day.");
                }
                else
                {
                    neededHearts[currentPossition] -= 2;
                    if (neededHearts[currentPossition] == 0)
                    {
                        Console.WriteLine($"Place {currentPossition} has Valentine's day.");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {currentPossition}.");
            int counter = 0;
            for (int i = 0; i < neededHearts.Count; i++)
            {

                if (neededHearts[i] == 0)
                {
                    counter++;
                }
            }
            if (counter == neededHearts.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neededHearts.Count - counter} places.");
            }
        }
    }
}
