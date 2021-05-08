using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            const  double priceOfRose = 5;
            const double priceOfDahlia = 3.80;
            const double priceOfTulip = 2.80;
            const double priceOfNarcissus = 3;
            const double priceOfGladiolus = 2.50;

            string typeOfFlower = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double finalPrice = 0;

            switch (typeOfFlower)
            {
                case "Roses":
                    if (countOfFlowers > 80)
                    {
                        finalPrice -= countOfFlowers * priceOfRose * 0.10;
                    }
                    finalPrice += countOfFlowers * priceOfRose;
                    break;
                case "Dahlias":
                    if (countOfFlowers > 90)
                    {
                        finalPrice -= countOfFlowers * priceOfDahlia * 0.15;
                    }
                    finalPrice += countOfFlowers * priceOfDahlia;
                    break;
                case "Tulips":
                    if (countOfFlowers > 80)
                    {
                        finalPrice -= countOfFlowers * priceOfTulip * 0.15;
                    }
                    finalPrice += countOfFlowers * priceOfTulip;
                    break;
                case "Narcissus":
                    if (countOfFlowers < 120)
                    {
                        finalPrice += countOfFlowers * priceOfNarcissus * 0.15;
                    }
                    finalPrice += countOfFlowers * priceOfNarcissus;
                    break;
                case "Gladiolus":
                    if (countOfFlowers < 80)
                    {
                        finalPrice += countOfFlowers * priceOfGladiolus * 0.20;
                    }
                    finalPrice += countOfFlowers * priceOfGladiolus;
                    break;
            }

            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }





        }
    }
}
