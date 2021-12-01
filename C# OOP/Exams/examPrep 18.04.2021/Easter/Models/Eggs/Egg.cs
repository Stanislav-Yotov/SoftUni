using Easter.Models.Eggs.Contracts;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;

        public Egg(string name, int energyRequired)
        {
            Name = name;
            EnergyRequired = energyRequired;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEggName);
                }
                name = value;
            }
        }

        public int EnergyRequired
        {
            get => energyRequired;
            private set
            {
                energyRequired = value < 0 ? 0 : value;
            }
        }

        public void GetColored()
        {
            energyRequired -= 10;
            if (energyRequired < 0)
            {
                energyRequired = 0;
            }
        }

        public bool IsDone()
        {
           return energyRequired == 0;
        }
    }
}
