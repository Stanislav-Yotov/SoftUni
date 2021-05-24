using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayType = Console.ReadLine();

            double singlePrice = 0;
            double totalPrice = 0;
            double discount = 0;

            if (groupType == "Students")
            {
                if (dayType == "Friday")
                {
                    singlePrice = 8.45;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 30)
                    {
                        totalPrice -= totalPrice * 0.15; 
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
                else if (dayType == "Saturday")
                {
                    singlePrice = 9.80;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
                else if (dayType == "Sunday")
                {
                    singlePrice = 10.46;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
            }
            else if (groupType == "Business")
            {
                if (dayType == "Friday")
                {
                    singlePrice = 10.90;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 100)
                    {
                        totalPrice = totalPrice - (singlePrice * 10);
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
                else if (dayType == "Saturday")
                {
                    singlePrice = 15.60;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 100)
                    {
                        totalPrice = totalPrice - (singlePrice * 10);
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
                else if (dayType == "Sunday")
                {
                    singlePrice = 16;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 100)
                    {
                        totalPrice = totalPrice - (singlePrice * 10);
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
            }
            else if (groupType == "Regular")
            {
                if (dayType == "Friday")
                {
                    singlePrice = 15;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 10 && groupCount <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
                else if (dayType == "Saturday")
                {
                    singlePrice = 20;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 10 && groupCount <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
                else if (dayType == "Sunday")
                {
                    singlePrice = 22.50;
                    totalPrice = singlePrice * groupCount;
                    if (groupCount >= 10 && groupCount <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    Console.WriteLine($"Total price: {totalPrice:f2}");
                }
            }

        }
    }
}
