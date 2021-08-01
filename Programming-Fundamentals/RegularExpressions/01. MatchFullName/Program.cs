using System;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            Regex regex = new Regex(pattern);

            string names = Console.ReadLine();

            MatchCollection validNames = Regex.Matches(names, pattern);

            foreach (Match name in validNames)
            {
                Console.Write($"{name.Value} ");
            }
            Console.WriteLine();
        }
    }
}
