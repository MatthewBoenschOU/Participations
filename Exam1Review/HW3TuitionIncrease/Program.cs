using System;

namespace HW3TuitionIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see how the tuition will increase over the next 7 years");

            double Tuition = 12000;
            double Rate = .05;

            for (int i = 1; i <= 7; i++)
            {
                Tuition = Tuition + (Tuition * Rate);
                Console.WriteLine($"The tuition after {i} year(s) is {Tuition.ToString("C2")}");
            }
            


        }
    }
}
