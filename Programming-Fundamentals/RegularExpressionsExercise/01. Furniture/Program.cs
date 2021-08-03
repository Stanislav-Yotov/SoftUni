using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";

            string input = Console.ReadLine();

            decimal sum = 0;

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string productName = match.Groups[1].Value;
                    decimal productPrice = decimal.Parse(match.Groups[2].Value);
                    int productQuantity = int.Parse(match.Groups[3].Value);
                    Console.WriteLine(productName);

                    sum += productPrice * productQuantity;

                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
