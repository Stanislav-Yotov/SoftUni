using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Dyes
{
    public class Dye : IDye
    {
        private int power;

        public Dye(int power)
        {
            Power = power;
        }

        public int Power
        {
            get => power;
            private set
            {
                power = value < 0 ? 0 : value;
            }
        }
            

        public bool IsFinished()
        {
            return power == 0;
        }

        public void Use()
        {
            power -= 10;
            if (power <= 0)
            {
                power = 0;
            }
        }
    }
}
