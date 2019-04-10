using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace HighSchool
{
    public class Student
    {

        public List<Student> Students { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _grade;

        public int Grade
        {
            get { return _grade; }

            set
            {
                if (value < 1)
                {
                    _grade = 1;
                }
                else if (value > 12)
                {
                    _grade = 12;
                }
                else
                {
                    _grade = value;
                }
            }
        }


        private double _currentGpa;

        public double GPA
        {
            get { return _currentGpa; }

            set
            {
                if (value < 0)
                {
                    _currentGpa = 0;
                }
                else if (value > 4)
                {
                    _currentGpa = 4;
                }
                else
                {
                    _currentGpa = value;
                }
            }


        }

        public static List<Student> StarStudents(List<Student> studentList)
        {
            //rtn a student list that only contains the students in Grade 9 -12, sorted by highest Grade, then high gpa, last name, first name

            return studentList.Where(student => student.Grade >= 9 && student.GPA >= 3)
                .OrderByDescending(student => student.Grade)
                .ThenByDescending(student => student.GPA)
                .ThenBy(student => student.LastName)
                .ThenBy(student => student.FirstName).ToList();
        }
    }


}
   

        



    