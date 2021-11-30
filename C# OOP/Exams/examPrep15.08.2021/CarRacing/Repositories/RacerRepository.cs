using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private readonly List<IRacer> models = new List<IRacer>();

        public IReadOnlyCollection<IRacer> Models => models.AsReadOnly();

        public void Add(IRacer racer)
        {
            if (racer == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository);
            }
            models.Add(racer);
        }

        public IRacer FindBy(string username)
        {
            IRacer racer = models.FirstOrDefault(r => r.Username == username);
            if (models.Contains(racer))
            {
                return racer;
            }
            return null;
        }

        public bool Remove(IRacer racer)
        {
            if (racer == null)
            {
                return false;
            }
            models.Remove(racer);
            return true;
        }

    }
}
