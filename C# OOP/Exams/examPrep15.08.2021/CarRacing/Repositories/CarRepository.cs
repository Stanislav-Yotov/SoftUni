using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> models = new List<ICar>();

        public IReadOnlyCollection<ICar> Models => models.AsReadOnly(); 

        public void Add(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }
            models.Add(car);
        }

        public ICar FindBy(string VIN)
        {
            ICar car = models.FirstOrDefault(c => c.VIN == VIN);
            if (models.Contains(car))
            {
                return car;
            }
            return null;
            
        }

        public bool Remove(ICar car)
        {
            if (car == null)
            {
                return false;
            }
            models.Remove(car);
            return true;
        }
    }
}
