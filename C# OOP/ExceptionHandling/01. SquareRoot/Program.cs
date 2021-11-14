using System;

namespace _01._SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string n = Console.ReadLine();
                ValidateNumber(n);
                double square = Math.Sqrt(double.Parse(n));
                Console.WriteLine(square);
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Invalid number");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }


        }

        private static void ValidateNumber(string n)
        {
            if (int.Parse(n) < 0)
            {
                throw new ArgumentException();
            }
            if (!int.TryParse(n, out _))
            {
                throw new ArgumentException();
            }
        }
    }
}
