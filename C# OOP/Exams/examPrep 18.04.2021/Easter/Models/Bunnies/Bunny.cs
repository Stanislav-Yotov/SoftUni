using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Models.Bunnies
{
    public abstract class Bunny : IBunny
    {
        private string name;
        private int energy;

        protected Bunny(string name, int energy)
        {
            Name = name;
            Energy = energy;
            Dyes = new List<IDye>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBunnyName);
                }
                name = value;
            }
        }

        public int Energy
        {
            get => energy;
            protected set
            {
                energy = value < 0 ? 0 : value;
            }
        }

        public ICollection<IDye> Dyes { get;  }

        public virtual void Work()
        {
            Energy -= 10;
            if (Energy < 0)
            {
                Energy = 0;
            }

            IDye dye = Dyes.First();
            dye.Use();
            if (dye.IsFinished())
            {
                Dyes.Remove(dye);
            }
        }

        public void AddDye(IDye dye)
        {
            this.Dyes.Add(dye);
        }
    }
}
