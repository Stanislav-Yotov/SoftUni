using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int animalsCount = int.Parse(Console.ReadLine());
            double dogFood = 2.50;
            double animalFood = 4.0;
            double dogFoodExpense = dogsCount * dogFood;
            double animalFoodExpense = animalsCount * animalFood;
            double neededMoney = dogFoodExpense + animalFoodExpense;
            Console.WriteLine($"{neededMoney} lv.");
        }
    }
}
