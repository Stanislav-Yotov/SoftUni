using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();
            string input;

            while ((input = Console.ReadLine().ToUpper()) != "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "IN")
                {
                    string car = command[1];
                    carPlates.Add(car);
                }
                else
                {
                    string car = command[1];
                    carPlates.Remove(car);
                }
            }

            Console.WriteLine(carPlates.Any() ? string.Join(Environment.NewLine, carPlates) : "Parking Lot is Empty");
        }
    }
}
