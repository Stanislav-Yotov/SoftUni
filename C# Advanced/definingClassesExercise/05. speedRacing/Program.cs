using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Car currentCar = new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]));
                cars.Add(currentCar);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitted = input.Split();
                cars.First(c => c.Model == splitted[1]).Drive(double.Parse(splitted[2]));
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
