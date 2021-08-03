using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfPeople = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionaryOfNames = new Dictionary<string, int>();

            foreach (var name in listOfPeople)
            {
                dictionaryOfNames.Add(name, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");

                int sum = 0;

                foreach (var digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;
                }

                if (dictionaryOfNames.ContainsKey(name))
                {
                    dictionaryOfNames[name] += sum;
                }

                input = Console.ReadLine();
            }

            int counter = 1;

            foreach (var kvp in dictionaryOfNames.OrderByDescending(x => x.Value))
            {
                string text = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";

                Console.WriteLine($"{counter++}{text} place: {kvp.Key}");

                if (counter == 4)
                {
                    break;
                }
            }
        }
    }
}
