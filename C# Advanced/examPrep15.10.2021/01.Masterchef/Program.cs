using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> freshnessLvl = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int dippingSauce = 0, greenSalad = 0, chocolateCake = 0, lobster = 0;

            while (ingredients.Count > 0 && freshnessLvl.Count > 0)
            {
                int ingredient = ingredients.Peek();
                int freshness = freshnessLvl.Peek();
                int totalFreshnessLvl = ingredient * freshness;
                if (totalFreshnessLvl == 150)
                {
                    dippingSauce++;
                    ingredients.Dequeue();
                    freshnessLvl.Pop();
                }
                else if (totalFreshnessLvl == 250)
                {
                    greenSalad++;
                    ingredients.Dequeue();
                    freshnessLvl.Pop();
                }
                else if (totalFreshnessLvl == 300)
                {
                    chocolateCake++;
                    ingredients.Dequeue();
                    freshnessLvl.Pop();
                }
                else if (totalFreshnessLvl == 400)
                {
                    lobster++;
                    ingredients.Dequeue();
                    freshnessLvl.Pop();
                }
                else if (ingredient == 0)
                {
                    ingredients.Dequeue();
                }
                else
                {
                    freshnessLvl.Pop();
                    ingredient += 5;
                    ingredients.Dequeue();
                    ingredients.Enqueue(ingredient);
                }
            }

            if (dippingSauce > 0 && greenSalad > 0 && chocolateCake > 0 && lobster > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($"# Chocolate cake --> {chocolateCake}");
                Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                Console.WriteLine($"# Green salad --> {greenSalad}");
                Console.WriteLine($"# Lobster --> {lobster}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredients.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                if (chocolateCake > 0)
                {
                    Console.WriteLine($"# Chocolate cake --> {chocolateCake}");
                }
                if (dippingSauce > 0)
                {
                    Console.WriteLine($"# Dipping sauce --> {dippingSauce}");
                }
                if (greenSalad > 0)
                {
                    Console.WriteLine($"# Green salad --> {greenSalad}");
                }
                if (lobster > 0)
                {
                    Console.WriteLine($"# Lobster --> {lobster}");
                }
            }

        }
    }
}





