using System;

namespace Exam1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money will you save a week?");
            double Principle = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What monthly interest rate will you recieve?");
            double InterestInput = Convert.ToDouble(Console.ReadLine());
            
            double Interest = InterestInput / 100;

            Console.WriteLine("How many years would you like to save for?");
            double TimeInYears = Convert.ToDouble(Console.ReadLine());

            double TotalForMonth = 0;
            double TotalTotal = 0;


            for (int i = 1; i <= TimeInYears*12; i++)
            {
                TotalForMonth = Principle + (Principle * Interest);
                TotalTotal += TotalForMonth; 

                Console.WriteLine($"On month {i} you saved {TotalForMonth}");
            }

            

            Console.ReadKey();
        }
    }
}
