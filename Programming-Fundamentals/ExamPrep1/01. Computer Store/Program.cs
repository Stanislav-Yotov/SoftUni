using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            decimal currentSum = 0m;
            decimal totalSum = 0m;
            decimal tax = 0m;

            while (command != "special" && command != "regular")
            {

                decimal price = decimal.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                }

                else
                {
                    currentSum += price;
                    tax = currentSum * 0.2m;
                    totalSum = currentSum + tax;

                    command = Console.ReadLine();
                }

            }

            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (command == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {currentSum:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }
            else if (command == "special")
            {
                totalSum = (currentSum + tax) - ((currentSum + tax) * 0.1m);
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {currentSum:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }


        }
    }
}
