using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseStudents = new Dictionary<string, List<string>>();
            List<string> studentData = Console.ReadLine()
                                              .Split(" : ")
                                              .ToList();

            while (studentData[0] != "end")
            {
                string course = studentData[0];
                string student = studentData[1];

                if (!courseStudents.ContainsKey(course))
                {
                    courseStudents.Add(course, new List<string>());
                    courseStudents[course].Add(student);
                    studentData = Console.ReadLine().Split(" : ").ToList();
                    continue;
                }

                courseStudents[course].Add(student);
                studentData = Console.ReadLine().Split(" : ").ToList();

            }

            foreach (var course in courseStudents.OrderByDescending(i => i.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value.Sort();
                Console.Write("-- ");

                Console.WriteLine(string.Join($"\n-- ", course.Value));
            }
                                      
        }
    }
}
