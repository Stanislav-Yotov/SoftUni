using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] buyerData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = buyerData[0];
                int age = int.Parse(buyerData[1]);

                if (buyerData.Length == 4)
                {
                    string id = buyerData[2];
                    string birthdate = buyerData[3];

                    IBuyer buyer = new Citizen(name, age, id, birthdate);
                    buyers.Add(name, buyer);
                }
                else if (buyerData.Length == 3)
                {
                    string group = buyerData[2];
                    IBuyer buyer = new Rebel(name, age, group);
                    buyers.Add(name, buyer);
                }
            }

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                if (buyers.ContainsKey(line))
                {
                    buyers[line].BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Value.Food));
        }
    }
}
