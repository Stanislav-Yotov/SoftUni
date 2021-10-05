﻿using System;
using System.Collections.Generic;
using System.Linq;
using static CarManufacturer.StartUp;

namespace CarManufacturer
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            string input;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] splitted = input.Split();
                List<string> setOfTires = new List<string>(splitted);

                Tire[] currentSetOfTire = new Tire[4];
                for (int i = 0; i < 4; i++)
                {
                    Tire currentTire = new Tire(int.Parse(setOfTires[0]), double.Parse(setOfTires[1]));
                    currentSetOfTire[i] = currentTire;
                    setOfTires.RemoveAt(0);
                    setOfTires.RemoveAt(0);

                }
                tires.Add(currentSetOfTire);
            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();
                Engine currentEngine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));
                engines.Add(currentEngine);
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = engines[int.Parse(carInfo[5])];
                Tire[] setOfTires = tires[int.Parse(carInfo[6])];
                Car currentCar = new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2]), double.Parse(carInfo[3]),
                    double.Parse(carInfo[4]), engine, setOfTires);
                cars.Add(currentCar);
            }

            cars = cars.Where(c =>
                c.Year >= 2017 && c.Engine.HorsePower > 330 && c.Tires.Sum(t => t.Pressure) >= 9 &&
                c.Tires.Sum(t => t.Pressure) <= 10).ToList();

            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}

           

