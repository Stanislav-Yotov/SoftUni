using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private int InitialSize = 5;

        public SaltwaterFish(string name, string species, decimal price) : base(name, species, price)
        {
            Size = InitialSize;
        }

        public override void Eat()
        {
            Size += 2;
        }
    }
}
