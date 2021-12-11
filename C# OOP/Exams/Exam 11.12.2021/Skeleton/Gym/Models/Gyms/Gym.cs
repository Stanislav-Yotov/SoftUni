using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private List<IEquipment> equipmentList;
        private List<IAthlete> athletes;

        public Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;

            equipmentList = new List<IEquipment>();
            athletes = new List<IAthlete>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }
                name = value;
            }
        }

        public int Capacity { get; }
        

        public double EquipmentWeight => equipmentList.Sum(e => e.Weight);

        public ICollection<IEquipment> Equipment => equipmentList;

        public ICollection<IAthlete> Athletes => athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if (athletes.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughSize);
            }
            athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            equipmentList.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} is a {GetType().Name}:");
            sb.AppendLine($"Athletes: {(Athletes.Count == 0 ? "No athletes" : string.Join(", ", athletes))}");
            sb.AppendLine($"Equipment total count: {equipmentList.Count}");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight:f2} grams");

            return sb.ToString().Trim();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return athletes.Remove(athlete);
        }
    }
}
