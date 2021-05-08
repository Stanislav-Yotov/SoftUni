using System;

namespace _06.salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int facebook = 150;
            const int instagram = 100;
            const int reddit = 50;

            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <n; i++)
            {
                string openedWebSites = Console.ReadLine();
                if (openedWebSites == "Facebook")
                {
                    salary -= facebook;
                }
                else if (openedWebSites == "Instagram")
                {
                    salary -= instagram;
                }
                else if (openedWebSites == "Reddit")
                {
                    salary -= reddit;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
