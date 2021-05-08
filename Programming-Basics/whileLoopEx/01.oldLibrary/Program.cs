using System;

namespace _01.oldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();

            int counter = 0;
            bool isFound = false;
            string nextBookName = Console.ReadLine();


            while (nextBookName != "No More Books")
            {
                if (nextBookName == favBook)
                {
                    isFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }

        }
    }
}
