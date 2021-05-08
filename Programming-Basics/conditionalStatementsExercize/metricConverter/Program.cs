using System;

namespace metricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string entry = Console.ReadLine();
            string exit = Console.ReadLine();
            if (entry == "mm" && exit == "m" )
            {
                num /= 1000;
            }
            else if (entry == "m" && exit == "mm")
            {
                num *= 1000;
            }
            else if (entry == "cm" && exit == "m")
            {
                num /= 100;
            }
            else if (entry == "m" && exit == "cm")
            {
                num *= 100;
            }
            else if (entry == "mm" && exit == "cm")
            {
                num /= 10;
            }
            else if (entry == "cm" && exit == "mm")
            {
                num *= 10;
            }
            Console.WriteLine($"{num:f3}");
            
            
            
        }
    }
}
