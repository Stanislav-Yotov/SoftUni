using System;
using System.Collections.Generic;

namespace _04._citiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new List<string>());
                }
                continentsData[continent][country].Add(city);
            }

            foreach (var continent in continentsData)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
