using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double calculateFactorialFirstNum = GetFactorial(a);
            double calculateFactorialSecondNum = GetFactorial(b);
            double result = calculateFactorialFirstNum / calculateFactorialSecondNum;

            Console.WriteLine($"{result:f2}");
        }

        private static double GetFactorial(int a)
        {
            double result = 1;
            while (a != 1)
            {
                result = result * a;
                a = a - 1;
            }
            return result;
        }
    }
}
