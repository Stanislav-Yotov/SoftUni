﻿using System;

namespace _05.journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double cost = 0;
            string destination = "";
            string accomodation = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    cost = budget * 0.3;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    cost = budget * 0.7;
                }
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{accomodation} - {cost:f2}");
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    cost = budget * 0.4;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    cost = budget * 0.8;
                }
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{accomodation} - {cost:f2}");
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer")
                {
                    accomodation = "Hotel";
                    cost = budget * 0.9;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    cost = budget * 0.9;
                }
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{accomodation} - {cost:f2}");
            }

        }
    }
}
