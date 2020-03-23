using System;

namespace HW3Tutor
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Rand = new Random();

            int rand1 = Rand.Next(0, 50);
            int rand2 = Rand.Next(0, 50);

            string Equation = ($"{rand1} + {rand2}");
            int CorrectAnswer = rand1 + rand2;

            Console.WriteLine("Can you solve this?");
            Console.WriteLine(Equation);
            int Answer = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                if (Answer == CorrectAnswer)
                {
                    Console.WriteLine("GG");
                   
                }
                else
                {
                    Console.WriteLine("Try again");
                    Console.WriteLine("Think you got it this time?");
                    Answer = Convert.ToInt32(Console.ReadLine());
                }
            } while (CorrectAnswer != Answer);
            



           






        }
    }
}
