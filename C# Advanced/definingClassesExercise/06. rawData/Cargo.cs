using System;
using System.Collections.Generic;
using System.Text;

namespace _06._rawData
{
   public class Cargo
    {
        public string Type { get; set; }
        public int Weight { get; set; }

        public Cargo(int weight, string type)
        {
            Type = type;
            Weight = weight;
        }
    }
}
