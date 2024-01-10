using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Student : Person
        {
            public string ClassAndSection { get; set; }

            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Class and Section: {ClassAndSection}\n");
            }
        }

        class Teacher : Person
        {
            public string ClassAndSection { get; set; }

            public void DisplayTeacherInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Class and Section: {ClassAndSection}\n");
            }
        }

        class Subject
        {
            public string Name { get; set; }
            public string SubjectCode { get; set; }
            public Teacher AssignedTeacher { get; set; }

            public void DisplaySubjectInfo()
            {
                Console.WriteLine($"Subject: {Name}");
                Console.WriteLine($"Subject Code: {SubjectCode}");
                Console.WriteLine($"Assigned Teacher: {AssignedTeacher.Name}\n");
            }
        }

        class program
        {
            static void Main()
            {
                List<Student> students = new List<Student>
        {
            new Student { Name = "Student1", Age = 20, ClassAndSection = "ClassA Section1" },
            new Student { Name = "Student2", Age = 21, ClassAndSection = "ClassB Section2" }
        };

                List<Teacher> teachers = new List<Teacher>
        {
            new Teacher { Name = "Teacher1", Age = 30, ClassAndSection = "ClassA Section1" },
            new Teacher { Name = "Teacher2", Age = 35, ClassAndSection = "ClassB Section2" }
        };

                List<Subject> subjects = new List<Subject>
        {
            new Subject { Name = "Math", SubjectCode = "M101", AssignedTeacher = teachers[0] },
            new Subject { Name = "Science", SubjectCode = "S201", AssignedTeacher = teachers[1] }
        };

                Console.WriteLine("Students in ClassA Section1:");
                foreach (var student in students)
                {
                    if (student.ClassAndSection == "ClassA Section1")
                    {
                        student.DisplayStudentInfo();
                    }
                }

                Console.WriteLine("Subjects taught by Teacher1:");
                foreach (var subject in subjects)
                {
                    if (subject.AssignedTeacher.Name == "Teacher1")
                    {
                        subject.DisplaySubjectInfo();
                    }
                }
            }
        }
    }
}
