using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split();
                string typeOfVehicle = cmdArgs[0].ToLower();
                string model = cmdArgs[1];
                string color = cmdArgs[2].ToLower();
                int horsePower = int.Parse(cmdArgs[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                catalogue.Add(vehicle);

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand != "Close the Catalogue")
            {
                string modelType = secondCommand;
                Vehicle printVehicle = catalogue.First(x => x.Model == modelType);

                Console.WriteLine(printVehicle);

                secondCommand = Console.ReadLine();
            }

            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarHp = onlyCars.Sum(x => x.HorsePower);
            double totalTruckHp = onlyTrucks.Sum(x => x.HorsePower);

            double averageCarHp = 0.00;
            double averageTruckHp = 0.00;

            if (onlyCars.Count > 0)
            {
                averageCarHp = totalCarHp / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                averageTruckHp = totalTruckHp / onlyTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}.");




        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }

    }
}
