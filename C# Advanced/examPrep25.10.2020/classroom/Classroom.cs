using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }

        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (students.Count + 1 <= Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student studentToDissmiss = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            if (studentToDissmiss == null)
            {
                return "Student not found";
            }
            else
            {
                students.Remove(studentToDissmiss);
                return $"Dismissed student {firstName} {lastName}";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            if (students.Any(s => s.Subject == subject))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var student in students)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No students enrolled for the subject";
            }

        }

        public int GetStudentsCount() => students.Count;

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(
                x => x.FirstName == firstName
                && x.LastName == lastName);
            return student;
        }


    }
}
