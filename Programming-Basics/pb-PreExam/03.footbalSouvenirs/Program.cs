using System;

namespace _03.footbalSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int souvenirCount = int.Parse(Console.ReadLine());
            double price = 0;
            double finalPrice = 0;

            if (team == "Argentina")
            {
                if (souvenirType == "flags")
                {
                    price = 3.25;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "caps")
                {
                    price = 7.20;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }

                else if (souvenirType == "posters")
                {
                    price = 5.10;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "stickers")
                {
                    price = 1.25;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Brazil")
            {
                if (souvenirType == "flags")
                {
                    price = 4.20;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "caps")
                {
                    price = 8.50;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }

                else if (souvenirType == "posters")
                {
                    price = 5.35;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "stickers")
                {
                    price = 1.20;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Croatia")
            {
                if (souvenirType == "flags")
                {
                    price = 2.75;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "caps")
                {
                    price = 6.90;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }

                else if (souvenirType == "posters")
                {
                    price = 4.95;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "stickers")
                {
                    price = 1.10;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team == "Denmark")
            {
                if (souvenirType == "flags")
                {
                    price = 3.10;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "caps")
                {
                    price = 6.50;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }

                else if (souvenirType == "posters")
                {
                    price = 4.80;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else if (souvenirType == "stickers")
                {
                    price = 0.90;
                    finalPrice = price * souvenirCount;
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {team} for {finalPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }



        }
    }
}
