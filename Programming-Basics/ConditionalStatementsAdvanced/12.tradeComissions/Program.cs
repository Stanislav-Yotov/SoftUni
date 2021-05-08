using System;

namespace _12.tradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = (sales / 100) * 5;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = (sales / 100) * 7;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = (sales / 100) * 8;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 10000)
                {
                    commision = (sales / 100) * 12;
                    Console.WriteLine($"{commision:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = (sales / 100) * 4.5;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = (sales / 100) * 7.5;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = (sales / 100) * 10;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 10000)
                {
                    commision = (sales / 100) * 13;
                    Console.WriteLine($"{commision:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = (sales / 100) * 5.5;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = (sales / 100) * 8;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = (sales / 100) * 12;
                    Console.WriteLine($"{commision:f2}");
                }
                else if (sales > 10000)
                {
                    commision = (sales / 100) * 14.5;
                    Console.WriteLine($"{commision:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
