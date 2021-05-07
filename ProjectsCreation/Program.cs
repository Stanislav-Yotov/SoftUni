using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int projectHours = 3;
            int project = projectCount * projectHours;
            Console.WriteLine($"The architect {name} will need {project} hours to complete {projectCount} project/s.");

        }
    }
}
