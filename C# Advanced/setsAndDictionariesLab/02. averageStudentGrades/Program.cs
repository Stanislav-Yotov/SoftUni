using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._averageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string studentName = studentInfo[0];
                decimal studentGrade = decimal.Parse(studentInfo[1]);
                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(v => $"{v:f2}"))} " +
                    $"(avg: {student.Value.Average():f2})");
            }
        }
    }
}



