using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            /* Bread       25
             Cake        50
             Pastry      75
             Fruit Pie   100*/
            int bread = 0, cake = 0, pastry = 0, fruitPie = 0;
            

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int liquid = liquids.Peek();
                int ingredient = ingredients.Peek();

                if (liquid + ingredient == 25)
                {
                    bread++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    
                }
                else if (liquid + ingredient == 50)
                {
                    cake++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    
                }
                else if (liquid + ingredient == 75)
                {
                    pastry++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    
                }
                else if (liquid + ingredient == 100)
                {
                    fruitPie++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    ingredient += 3;
                    ingredients.Push(ingredient);
                }

            }

            if (bread > 0 && cake > 0 && pastry > 0 && fruitPie > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Any())
            {
                Console.Write("Liquids left:" + " ");
                Console.Write(string.Join(", ", liquids));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (ingredients.Any())
            {
                Console.Write("Ingredients left:" + " ");
                Console.Write(string.Join(", ", ingredients));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");



        }
    }
}
