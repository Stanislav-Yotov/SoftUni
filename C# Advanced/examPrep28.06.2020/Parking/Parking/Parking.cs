using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Car car)
        {
            if (data.Count + 1 <= Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car carToRemove = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
            if (carToRemove == null)
            {
                return false;
            }
            else
            {
                data.Remove(carToRemove);
                return true;
            }
        }

        public Car GetLatestCar() => data.OrderByDescending(c => c.Year).FirstOrDefault();

        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.Find(c => c.Manufacturer == manufacturer && c.Model == model);
            if (car != null)
            {
                return car;
            }
            else
            {
                return null;
            }
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}
