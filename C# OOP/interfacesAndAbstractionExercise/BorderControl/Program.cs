using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] identifiableData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IIdentifiable identifiable;
                if (identifiableData.Length == 3)
                {
                    string name = identifiableData[0];
                    int age = int.Parse(identifiableData[1]);
                    string id = identifiableData[2];

                    identifiable = new Citizen(name, age, id);
                }
                else
                {
                    string model = identifiableData[0];
                    string id = identifiableData[1];

                    identifiable = new Robot(model, id);
                }

                identifiables.Add(identifiable);

                //input = Console.ReadLine();
            }

            string lastDigits = Console.ReadLine();

            foreach (var identifiable in identifiables)
            {
                if (identifiable.Id.EndsWith(lastDigits))
                {
                    Console.WriteLine(identifiable.Id);
                }
            }
        }
    }
}
