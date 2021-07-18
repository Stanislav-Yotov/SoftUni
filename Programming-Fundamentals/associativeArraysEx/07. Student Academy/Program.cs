using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            Dictionary<string, List<double>> studentInfo = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentInfo.ContainsKey(studentName))
                {
                    studentInfo.Add(studentName, new List<double>());
                    studentInfo[studentName].Add(grade);
                    continue;
                }
                studentInfo[studentName].Add(grade);
            }

            studentInfo = studentInfo.Where(s => s.Value.Average() >= 4.5).ToDictionary(s => s.Key, s => s.Value);

            foreach (var student in studentInfo.OrderByDescending(s => s.Value.Average())) 
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }


                                    
        }
    }
}
