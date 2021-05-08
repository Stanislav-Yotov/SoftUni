using System;

namespace _01.painting
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintCansCount = int.Parse(Console.ReadLine());
            int wallPaperCount = int.Parse(Console.ReadLine());
            double glovesPrice = double.Parse(Console.ReadLine());
            double brushPrice = double.Parse(Console.ReadLine());

            double paintCanPrice = 21.50;
            double wallPaperPrice = 5.20;
            double glovesCount = Math.Ceiling(wallPaperCount * 0.35);
            double brushCount = Math.Floor(paintCansCount * 0.48);

            double totalPrice = (paintCansCount * 1.0 * paintCanPrice) + (wallPaperCount * 1.0 * wallPaperPrice) + (glovesCount * glovesPrice) + (brushCount * brushPrice);
            double deliveryPrice = totalPrice / 15;
            Console.WriteLine($"This delivery will cost {deliveryPrice:f2} lv.");
        }
    }
}
