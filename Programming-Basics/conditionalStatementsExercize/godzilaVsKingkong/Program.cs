using System;

namespace godzilaVsKingkong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int stuntMen = int.Parse(Console.ReadLine());
            double clothesPricePerPerson = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double totalClothesPrice = stuntMen * clothesPricePerPerson;
            if (stuntMen > 150)
            {
                double discount = totalClothesPrice * 0.10;
                totalClothesPrice -= discount;
            }
            double totalMoney = decorPrice + totalClothesPrice;
            double neededMoney = totalMoney - budget;
            if (totalMoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
