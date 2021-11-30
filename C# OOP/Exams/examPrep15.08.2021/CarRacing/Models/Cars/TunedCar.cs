using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public class TunedCar : Car
    {
        private const double initialFuelAvailable = 65;
        private const double initialFuelConsumptionPerRace = 7.5;
        public TunedCar(string make, string model, string vin, int horsePower) 
            : base(make, model, vin, horsePower, 65, 7.5)
        {
        }

        public override void Drive()
        {
            HorsePower -= (HorsePower / 100) * 3;
            base.Drive();
        }
    }
}
