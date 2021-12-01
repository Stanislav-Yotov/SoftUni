using Easter.Models.Bunnies.Contracts;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Repositories
{
    public class BunnyRepository : IRepository<IBunny>
    {
        private readonly List<IBunny> models = new List<IBunny>();

        public IReadOnlyCollection<IBunny> Models => models.AsReadOnly();

        public void Add(IBunny bunny)
        {
            if (!models.Contains(bunny))
            {
                models.Add(bunny);
            }
        }

        public IBunny FindByName(string name)
        {
            return models.FirstOrDefault(n => n.Name == name);
        }

        public bool Remove(IBunny bunny)
        {
            if (models.Contains(bunny))
            {
                models.Remove(bunny);
                return true;
            }
            return false;
           
        }
    }
}
