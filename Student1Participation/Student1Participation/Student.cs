using System;
using System.Collections.Generic;
using System.Text;

namespace Student1Participation
{
    class Student
    {
        double GradePointValue;
        double CreditHours;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> CourseNames { get; set; }
        public List<string> CourseGrades { get; set; }

        public Student ()
        {
            FirstName = "";
            LastName = "";
            CourseNames = CourseNames;
            CourseGrades = CourseGrades;
        }

        public Student(string first, string second)
        {
            FirstName = first;
            LastName = second;
        }

        
        public double CalculateGPA ()
        {
           
            double GPA = (GradePointValue * CreditHours) / CreditHours;

            return GPA;
        }


    }
}
