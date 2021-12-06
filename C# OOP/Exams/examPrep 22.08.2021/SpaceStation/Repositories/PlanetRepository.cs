using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> planets = new List<IPlanet>();

        public IReadOnlyCollection<IPlanet> Models => planets;

        public void Add(IPlanet model)
        {
            planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            IPlanet planet = planets.FirstOrDefault(x => x.Name == name);
            return planet;
        }

        public bool Remove(IPlanet model)
        {
            return planets.Remove(model);
        }
    }
}
