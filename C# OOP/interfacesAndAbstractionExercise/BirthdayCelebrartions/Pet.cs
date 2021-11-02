using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrartions
{
    public class Pet : IPet, IBirthable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; }

        public string Birthdate { get; }
    }
}
