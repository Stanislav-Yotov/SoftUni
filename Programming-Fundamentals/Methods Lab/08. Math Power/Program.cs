using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(num, power));
        }

        static double RaiseToPower(double num, double power)
        {
            double result = Math.Pow(num, power);
            return result;
        }
    }
}
