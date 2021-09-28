using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._productShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string line;

            while ((line = Console.ReadLine()) != "Revision")
            {
                string[] productsInfo = line.Split(", ");
                string shop = productsInfo[0];
                string product = productsInfo[1];
                double price = double.Parse(productsInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop][product] = price;
                }
            }



            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

        }
    }
}
