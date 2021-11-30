using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public class ProfessionalRacer : Racer
    {
        private const int initialDrivingExperience = 30;
        private const string initialRacingBehavior = "strict";

        public ProfessionalRacer(string username, ICar car) 
            : base(username, "strict", 30, car)
        {
        }
        public override void Race()
        {
            DrivingExperience += 10;
            base.Race();
        }
    }
}
