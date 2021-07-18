using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<double>> product = new Dictionary<string, List<double>>();




            while (command != "buy")
            {



                string[] cmdArgs = command.Split();
                string name = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                double quantity = double.Parse(cmdArgs[2]);

                if (!product.ContainsKey(name))
                {
                    List<double> priceAndQuantity = new List<double> { price, quantity };
                    product.Add(name, priceAndQuantity);

                }
                else
                {
                    product[name][0] = price;
                    product[name][1] += quantity;
                }

                command = Console.ReadLine();
            }

            foreach (var item in product)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
