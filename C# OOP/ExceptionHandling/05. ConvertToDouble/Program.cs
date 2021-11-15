using System;

namespace _05._ConvertToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double result;
            foreach (var item in input)
            {
                try
                {

                    result = Convert.ToDouble(item);
                    if (double.IsPositiveInfinity(result) || double.IsNegativeInfinity(result))
                    {
                        throw new OverflowException();
                    }
                    Console.WriteLine($"Converted '{item}' to {result}");
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
