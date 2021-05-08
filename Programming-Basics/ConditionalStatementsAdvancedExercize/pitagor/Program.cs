using System;

namespace pitagor
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            

            double result = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine(result);

        }
    }
}
