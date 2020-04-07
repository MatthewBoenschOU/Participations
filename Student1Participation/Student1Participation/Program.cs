using System;

namespace Student1Participation
{
    class Program
    {
        static void Main(string[] args)
        {

            string Answer;
            double GradePointValue;
            double CreditHours;

            Student StudentTest = new Student();

            Console.WriteLine("Please enter your first name");
            StudentTest.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            StudentTest.LastName = Console.ReadLine();

            do
            {
                Console.WriteLine("Please enter your class name");
                StudentTest.CourseNames.Add(Console.ReadLine());
                
                Console.WriteLine("Please enter your grade in that class");
                StudentTest.CourseGrades.Add(Console.ReadLine());

                Console.WriteLine("Would you like to add another class?");
                Answer = Console.ReadLine();

            } while (Answer =="y");

            

            Console.WriteLine($"{StudentTest.FirstName} {StudentTest.LastName} Your grade for {StudentTest.CourseNames} was {StudentTest.CourseGrades}, is that correct?");
            Console.WriteLine($"Your GPA is {StudentTest.CalculateGPA()}");
            


            
            
            

        }
    }
}
