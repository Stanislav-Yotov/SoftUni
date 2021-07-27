using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries);





            for (int i = 0; i < usernames.Length; i++)
            {
                string curUsername = usernames[i];

                if (isValid(curUsername))
                {
                    Console.WriteLine(curUsername);
                }
            }



        }

        public static bool isValid(string curent)
        {
            return curent.Length >= 3 &&
                   curent.Length <= 16 &&
                   curent.All(c => char.IsLetterOrDigit(c)) ||
                   curent.Contains("-") ||
                   curent.Contains("_");
        }
    }
}
