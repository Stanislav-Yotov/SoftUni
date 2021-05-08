using System;

namespace _05.puppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int foodCounter = 0;

            int foodInGrams = food * 1000;

            while (command != "Adopted")
            {
                int nextMeal = int.Parse(command);
                foodCounter += nextMeal;
                command = Console.ReadLine();
            }

            if (foodInGrams >= foodCounter)
            {
                int leftFood = foodInGrams - foodCounter;
                Console.WriteLine($"Food is enough! Leftovers: {leftFood} grams.");
            }
            else
            {
                int neededFood = foodCounter - foodInGrams;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
        
           
                
                    


        }
    }
}
