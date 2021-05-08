using System;

namespace _05.accountBalance
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double num = double.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += num;
                Console.WriteLine($"Increase: {num:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");


        }
    }
}
