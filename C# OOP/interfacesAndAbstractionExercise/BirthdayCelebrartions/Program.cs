using System;
using System.Collections.Generic;

namespace BirthdayCelebrartions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();
            string line;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] birthableData = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = birthableData[0];
                IBirthable birthable;
                if (type == nameof(Citizen))
                {
                    string name = birthableData[1];
                    int age = int.Parse(birthableData[2]);
                    string id = birthableData[3];
                    string birthdate = birthableData[4];

                    birthable = new Citizen(name, age, id, birthdate);
                    birthables.Add(birthable);
                }
                else if (type == nameof(Pet))
                {
                    string name = birthableData[1];
                    string birthdate = birthableData[2];

                    birthable = new Pet(name, birthdate);
                    birthables.Add(birthable);
                }

            }
            string filterYear = Console.ReadLine();

            foreach (var birthable in birthables)
            {
                if (birthable.Birthdate.EndsWith(filterYear))
                {
                    Console.WriteLine(birthable.Birthdate);
                }
            }
        }
    }
}

                
                
