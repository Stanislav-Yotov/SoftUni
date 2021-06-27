using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string firstName = info[0];
                string lastname = info[1];
                double grade = double.Parse(info[2]);

                Student student = new Student(firstName, lastname, grade);
                students.Add(student);
            }
            students = students.OrderByDescending(a => a.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}