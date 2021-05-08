using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double squareMeterPrice = 7.61;
            double finalPrice = squareMeters * squareMeterPrice;
            double discount = (finalPrice / 100) * 18;
            double price = finalPrice - discount;
            Console.WriteLine($"The final price is: {price} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
