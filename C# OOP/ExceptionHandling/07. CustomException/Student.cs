using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._CustomException
{
    public class Student
    {
        private string name;
        private string email;

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name 
        {
            get => name;
            set
            {
                if (value.Any(c => !char.IsLetter(c)))
                {
                    throw new InvalidPersonNameException("Name must contain only letters");
                }
                value = name;
            }
        }

        public string Email { get; set; }
    }
}
