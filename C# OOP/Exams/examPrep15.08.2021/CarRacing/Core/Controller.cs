using CarRacing.Core.Contracts;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Repositories;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Models.Maps;
using CarRacing.Repositories.Contracts;

namespace CarRacing.Core
{
    public class Controller : IController
    {
        private IRepository<ICar> cars;
        private IRepository<IRacer> racers;
        private IMap map;

        public Controller()
        {
            cars = new CarRepository();
            racers = new RacerRepository();
            map = new Map();
        }

        public object IPlayer { get; private set; }

        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            ICar car;
            if (type == nameof(SuperCar))
            {
                car = new SuperCar(make, model, VIN, horsePower);
            }
            else if (type == nameof(TunedCar))
            {
                car = new TunedCar(make, model, VIN, horsePower);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidCarType);
            }
            cars.Add(car);
            return $"Successfully added car {car.Make} {car.Model} ({VIN}).";
        }

        public string AddRacer(string type, string username, string carVIN)
        {
            ICar car = cars.FindBy(carVIN);
            IRacer player;
            if (car is null)
            {
                throw new ArgumentException(ExceptionMessages.CarCannotBeFound);
            }
            if (type == nameof(ProfessionalRacer))
            {
                player = new ProfessionalRacer(username, car);
            }
            else if (type == nameof(StreetRacer))
            {
                player = new StreetRacer(username, car);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidRacerType);
            }

            racers.Add(player);
            return $"Successfully added racer {player.Username}.";

        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            var firstRacer = racers.FindBy(racerOneUsername);
            var secondRacer = racers.FindBy(racerTwoUsername);

            if (firstRacer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RacerCannotBeFound, racerOneUsername));
            }
            if (secondRacer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RacerCannotBeFound, racerTwoUsername));
            }
            return map.StartRace(firstRacer, secondRacer);
        }



        public string Report()
        {
            var players = racers.Models
                          .OrderByDescending(p => p.DrivingExperience)
                          .ThenBy(p => p.Username)
                          .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var racer in players)
            {
                sb.AppendLine($"{racer.GetType().Name}: {racer.Username}");
                sb.AppendLine($"--Driving behavior: {racer.RacingBehavior}");
                sb.AppendLine($"--Driving experience: {racer.DrivingExperience}");
                sb.AppendLine($"--Car: {racer.Car.Make} {racer.Car.Model} ({racer.Car.VIN})");
            }

            return sb.ToString().TrimEnd();
        }


    }
}
