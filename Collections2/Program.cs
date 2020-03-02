using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] CourseNumberArray = new int [3];
            string[] CourseNameArray = new string [3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Input a course");
                CourseNameArray[i] = Console.ReadLine();

                Console.WriteLine("Input a course number");
                CourseNumberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{CourseNameArray[i]} {CourseNumberArray[i]}");
            }


            //////////////////////////////////////////////////////////////////////////////////

            List<double> ExamScores = new List<double>();
            string UserAnswer = "";
            do
            {
                Console.WriteLine("Please enter an exam score");
                double Score = Convert.ToDouble(Console.ReadLine());
                ExamScores.Add(Score);

                Console.WriteLine("Would you like to enter another score? y/n");
                UserAnswer = Console.ReadLine();

            } while (UserAnswer.ToLower() == "yes" || UserAnswer.ToLower() == "y");

            double TotalScore = 0;

            foreach (var Score in ExamScores)
            {

                TotalScore = TotalScore + Score;
                Console.WriteLine($"Your score is {Score} which makes your total score {TotalScore}");
            }
            double Average = TotalScore / ExamScores.Count();

            Console.WriteLine($"Your average score for {ExamScores.Count} exam grafes is {Average.ToString("N2")}");

            //////////////////////////////////////////////////////////////////////////////////


            Dictionary<string, int> CourseCode = new Dictionary<string, int>();

            CourseCode.Add(CourseNameArray[0], CourseNumberArray[0]);


            Console.ReadKey();
        }
    }
}
