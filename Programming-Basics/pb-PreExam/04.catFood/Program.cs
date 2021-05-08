using System;

namespace _04.catFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsCount = int.Parse(Console.ReadLine());

            double catFoodPrice = 12.45;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            double foodCounter = 0;

            for (int i = 1; i <= catsCount; i++)
            {
                double food = double.Parse(Console.ReadLine());
                foodCounter += food;
                if (food >= 100 && food < 200)
                {
                    group1++;
                }
                else if (food >= 200 && food < 300)
                {
                    group2++;
                }
                else if (food >= 300 && food <= 400)
                {
                    group3++;
                }
            }
            double priceOfFoodPerDay = (foodCounter / 1000) * catFoodPrice;
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {priceOfFoodPerDay:f2} lv.");



        }
    }
}
