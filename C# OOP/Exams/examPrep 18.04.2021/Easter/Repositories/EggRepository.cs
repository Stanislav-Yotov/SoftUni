using Easter.Models.Eggs.Contracts;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Repositories
{
    public class EggRepository : IRepository<IEgg>
    {
        private readonly List<IEgg> models = new List<IEgg>();

        public IReadOnlyCollection<IEgg> Models => models.AsReadOnly();

        public void Add(IEgg egg)
        {
            if (!models.Contains(egg))
            {
                models.Add(egg);
            }
           
        }

        public IEgg FindByName(string name)
        {
            return models.FirstOrDefault(n => n.Name == name);
        }

        public bool Remove(IEgg egg)
        {
            return models.Remove(egg);
        }
    }
}
