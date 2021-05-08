using System;

namespace _06.goldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationCount = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int i = 1; i <= locationCount; i++)
            {
                double expectedAverageProduction = double.Parse(Console.ReadLine());
                int daysOfExcavation = int.Parse(Console.ReadLine());
                double averageProdution = 0;
                double dailyProdution = 0;

                for (int j = 1; j <= daysOfExcavation; j++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    dailyProdution += goldPerDay;
                    averageProdution = dailyProdution / daysOfExcavation;
                }

                if (averageProdution >= expectedAverageProduction)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageProdution:f2}.");
                }
                else
                {
                    double insuficientGold = expectedAverageProduction - averageProdution;
                    Console.WriteLine($"You need {insuficientGold:f2} gold.");
                }
            }
        }
    }
}
