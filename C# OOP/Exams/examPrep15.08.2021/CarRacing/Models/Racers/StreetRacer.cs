﻿using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public class StreetRacer : Racer
    {
        private const int initialDrivingExperience = 10;
        private const string initialRacingBehavior = "aggressive";

        public StreetRacer(string username, ICar car) 
            : base(username, "aggressive", 10, car)
        {
        }

        public override void Race()
        {
            DrivingExperience += 5;
            base.Race();
        }
    }
}