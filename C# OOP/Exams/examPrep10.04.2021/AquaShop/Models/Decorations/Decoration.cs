using AquaShop.Models.Decorations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models
{
    public abstract class Decoration : IDecoration
    {
        private int comfort;
        private decimal price;

        protected Decoration(int comfort, decimal price)
        {
            Comfort = comfort;

        }

        public int Comfort
        {
            get => comfort;
            private set
            {
                comfort = value;
            }
        }

        public decimal Price
        {
            get => price;
            private set
            {
                price = value;
            }
        }
    }
}
