using Gym.Core.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Repositories.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Athletes;

namespace Gym.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IEquipment> equipment;
        private readonly List<IGym> gyms;

        public Controller()
        {
            equipment = new EquipmentRepository();
            gyms = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete currentAthlete;
            if (athleteType == nameof(Boxer))
            {
                currentAthlete = new Boxer(athleteName, motivation, numberOfMedals);
            }
            else if (athleteType == nameof(Weightlifter))
            {
                currentAthlete = new Weightlifter(athleteName, motivation, numberOfMedals);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            }

            IGym currentGym = gyms.FirstOrDefault(g => g.Name == gymName);
            if (athleteType == "Boxer" && currentGym.GetType().Name != nameof(BoxingGym))
            {
                return OutputMessages.InappropriateGym;
            }
            else if (athleteType == "Weightlifter" && currentGym.GetType().Name != nameof(WeightliftingGym))
            {
                return OutputMessages.InappropriateGym;
            }

            currentGym.AddAthlete(currentAthlete);
            return string.Format(OutputMessages.EntityAddedToGym, athleteType, gymName);
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment currentEquipment;
            if (equipmentType == nameof(BoxingGloves))
            {
                currentEquipment = new BoxingGloves();
            }
            else if (equipmentType == nameof(Kettlebell))
            {
                currentEquipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }
            equipment.Add(currentEquipment);
            return string.Format(OutputMessages.SuccessfullyAdded, equipmentType);
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym;
            if (gymType == nameof(BoxingGym))
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == nameof(WeightliftingGym))
            {
                gym = new WeightliftingGym(gymName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }
            gyms.Add(gym);
            return string.Format(OutputMessages.SuccessfullyAdded, gymType);
        }

        public string EquipmentWeight(string gymName)
        {
            IGym currentGym = gyms.FirstOrDefault(g => g.Name == gymName);
            var value = currentGym.Equipment.Sum(e => e.Weight);
            return string.Format(OutputMessages.EquipmentTotalWeight, gymName, value);
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment currentEquipment = equipment.FindByType(equipmentType);
            if (currentEquipment == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentEquipment, equipmentType));
            }

            IGym currentGym = gyms.FirstOrDefault(g => g.Name == gymName);
            currentGym.Equipment.Add(currentEquipment);
            equipment.Remove(currentEquipment);
            return string.Format(OutputMessages.EntityAddedToGym, equipmentType, gymName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var gym in gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }
            return sb.ToString().Trim();
        }

        public string TrainAthletes(string gymName)
        {
            IGym curentGym = gyms.FirstOrDefault(g => g.Name == gymName);
            curentGym.Exercise();
            return string.Format(OutputMessages.AthleteExercise, curentGym.Athletes.Count);
        }
    }
}
