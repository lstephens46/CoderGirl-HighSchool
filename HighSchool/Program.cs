using System;
using System.Collections.Generic;

namespace HighSchool
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> studentList = new List<Student>
            {
                new Student {FirstName = "Kim", LastName = "Warner", Grade = 5, GPA = 3.7},
                new Student {FirstName = "Lauren", LastName = "Stephens", Grade = 12, GPA = 3.9},
                new Student {FirstName = "Johnathan", LastName = "Stephens", Grade = 12, GPA = 3.0},
                new Student {FirstName = "Harry", LastName = "Strode", Grade = 7, GPA = 2.6},
                new Student {FirstName = "Sally", LastName = "Rhoades", Grade = 11, GPA = 4.0},
                new Student {FirstName = "John", LastName = "Stephens", Grade = 3, GPA = 2.9},
                new Student {FirstName = "Tim", LastName = "Ema", Grade = 9, GPA = 4.0},
                new Student {FirstName = "Jeremy", LastName = "Owens", Grade = 2, GPA = 1.0},
                new Student {FirstName = "Trey", LastName = "Porter", Grade = 10, GPA = 3.6},
                new Student {FirstName = "David", LastName = "Wilson", Grade = 12, GPA = 3.4},
                new Student {FirstName = "Julie", LastName = "Sims", Grade = 4, GPA = 2.3},
                new Student {FirstName = "Wally", LastName = "Wood", Grade = 6, GPA = 0.4},
                new Student {FirstName = "Jimmy", LastName = "LittleJohn", Grade = 8, GPA = 3.8}
            };

            List<Student> inHighSchooList = Student.StarStudents(studentList);
            foreach (Student student in inHighSchooList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Grade} {student.GPA}");
            }

            Console.ReadLine();
        }
    }
}
