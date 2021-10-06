using System;
using System.Collections.Generic;
using System.Text;

namespace _06._rawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public List<Tire> Tires { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string model, Engine engine, List<Tire> tires, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Tires = tires;
            Cargo = cargo;
        }
        public override string ToString()
        {
            return Model;
        }
    }
}
