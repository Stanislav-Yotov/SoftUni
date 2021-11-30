using CarRacing.Models.Cars;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            string outcomeMessage = string.Empty;
            if (!racerOne.IsAvailable())
            {

                outcomeMessage = $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            else if (!racerTwo.IsAvailable())
            {
                outcomeMessage = $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            else if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                outcomeMessage = "Race cannot be completed because both racers are not available!";
            }

            if (racerOne.IsAvailable() && racerTwo.IsAvailable())
            {
                racerOne.Race();
                racerTwo.Race();
                double multiplier = 0;
                if (racerOne.RacingBehavior == "strict" || racerTwo.RacingBehavior == "strict")
                {
                    multiplier = 1.2;
                }
                if (racerOne.RacingBehavior == "aggressive" || racerTwo.RacingBehavior == "aggressive")
                {
                    multiplier = 1.1;
                }

                double racerOneChanceOfWining = racerOne.Car.HorsePower * racerOne.DrivingExperience * multiplier;
                double racerTwoChanceOfWining = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * multiplier;
                if (racerOneChanceOfWining > racerTwoChanceOfWining)
                {
                    outcomeMessage = $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerOne.Username} is the winner!";
                }
                else
                {
                    outcomeMessage = $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerTwo.Username} is the winner!";
                }
            }
            return outcomeMessage;


        }
    }
}






