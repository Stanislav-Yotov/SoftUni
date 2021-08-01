using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            Regex regex = new Regex(pattern);

            string phones = Console.ReadLine();

            MatchCollection validPhones = Regex.Matches(phones, pattern);

            var matchedPhones = validPhones
                               .Cast<Match>()
                               .Select(a => a.Value.Trim())
                               .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));

        }
    }
}
