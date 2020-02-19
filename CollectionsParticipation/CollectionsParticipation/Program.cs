using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer;
            double Sum = 0;
            List<double> ExamScores = new List<double>();

            do
            {
                Console.WriteLine("Please enter your exam grade");
                double ExamInput = Convert.ToDouble(Console.ReadLine());
                ExamScores.Add(ExamInput);
                Sum += ExamInput;

                Console.WriteLine("Would you like to add another exam score? (y,n)");
                Answer = Console.ReadLine();
            } while (Answer.ToLower() == "y");

            double Max = ExamScores[0];
            double Min = ExamScores[0];
            double AVG = Sum / ExamScores.Count;

            for (int i = 0; i < ExamScores.Count; i++)
            {
                if (ExamScores[i] > Max)
                {
                    Max = ExamScores[i];
                }
                if (ExamScores[i]<Min)
                {
                    Min = ExamScores[i];
                }
            }

            Console.WriteLine($"Your Maximum score is {Max}");
            Console.WriteLine($"Your Minimum score is {Min}");
            Console.WriteLine($"Your Average score is {AVG}");

            Console.ReadLine();

        }
    }
}
