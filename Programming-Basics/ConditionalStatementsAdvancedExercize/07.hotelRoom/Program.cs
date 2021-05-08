using System;

namespace _07.hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double overnights = double.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            double finalPriceStudio = 0;
            double finalPriceApartment = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                finalPriceStudio = studioPrice * overnights;
                finalPriceApartment = apartmentPrice * overnights;
                if (overnights > 14)
                {
                    finalPriceApartment -= finalPriceApartment * 0.10;
                    finalPriceStudio -= finalPriceStudio * 0.3;
                }
                else if (overnights > 7)
                {
                    finalPriceStudio -= finalPriceStudio * 0.05;
                }
                Console.WriteLine($"Apartment: {finalPriceApartment:f2} lv.");
                Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                finalPriceStudio = studioPrice * overnights;
                finalPriceApartment = apartmentPrice * overnights;
                if (overnights > 14)
                {
                    finalPriceStudio -= finalPriceStudio * 0.2;
                    finalPriceApartment -= finalPriceApartment * 0.1;
                }
                Console.WriteLine($"Apartment: {finalPriceApartment:f2} lv.");
                Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                finalPriceStudio = studioPrice * overnights;
                finalPriceApartment = apartmentPrice * overnights;
                if (overnights > 14)
                {
                    finalPriceApartment -= finalPriceApartment * 0.1;
                }
                Console.WriteLine($"Apartment: {finalPriceApartment:f2} lv.");
                Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
            }



        }
    }
}
