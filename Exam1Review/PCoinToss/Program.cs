using System;

namespace PCoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();

            int Toss = Rand.Next(0, 1);
            string TossAsString = "";
            if (Toss == 1)
            {
                TossAsString = "Heads";
            }
            else
            {
                TossAsString = "Tails";
            }
            int Guess = 0;

            Console.WriteLine("Heads or tails?");
            string GuessAsString = Console.ReadLine().ToLower();

            if (GuessAsString == "heads")
            {
                Guess = 0;
            }
            else if (GuessAsString == "tails")
            {
                Guess = 1;
            }
            else
            {
                Console.WriteLine("Please enter a valid answer");
            }

            do
            {
                Console.WriteLine($"You guessed {GuessAsString} and the coin landed on {TossAsString} please try again");
                Console.WriteLine("Guess again");
                Guess = Convert.ToInt32(Console.ReadLine());
            } while (Guess != Toss);

            Console.WriteLine("You got it right!");
           

            

            Console.ReadKey();



        }
    }
}
