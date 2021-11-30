using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public class SuperCar : Car
    {
        private const double initialFuelAvailable = 80;
        private const double initalFuelConsumtpionPerRace = 10;

        public SuperCar(string make, string model, string vin, int horsePower) 
            : base(make, model, vin, horsePower, 80, 10)
        {
        }
    }
}
