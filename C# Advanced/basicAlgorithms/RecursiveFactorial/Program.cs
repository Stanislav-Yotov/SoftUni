using System;

namespace _02._RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double result = 1;
            Console.WriteLine(Factorial(n, result));
        }

        static double Factorial(double x, double result)
        {

            if (x <= 1)
            {
                return result;
            }

            result *= x;
            x--;
            return Factorial(x, result);
        }
    }
}
