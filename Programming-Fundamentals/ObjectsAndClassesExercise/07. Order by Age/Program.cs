using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = Console.ReadLine();
            List<Person> personToPrint = new List<Person>();


            while (lines != "End")
            {
                string[] tokens = lines.Split();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(name, id, age);
                personToPrint.Add(person);

                lines = Console.ReadLine();
            }

            personToPrint = personToPrint.OrderBy(a => a.Age).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, personToPrint));
        }
    }

    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }
}
