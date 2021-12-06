using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        private List<IAstronaut> astronauts = new List<IAstronaut>();

        public IReadOnlyCollection<IAstronaut> Models => astronauts;

        public void Add(IAstronaut model)
        {
            astronauts.Add(model);
        }

        public IAstronaut FindByName(string name)
        {
            IAstronaut astronaut = astronauts.FirstOrDefault(x => x.Name == name);
            return astronaut;
        }

        public bool Remove(IAstronaut model)
        {
            return astronauts.Remove(model);
        }
    }
}
