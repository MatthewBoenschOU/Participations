using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which participation would you like to run? (FizzBuzz, CoinToss, Collections, etc.)");
            string ParticipationAnswer = Console.ReadLine();

            if (ParticipationAnswer == "CoinToss")
            {
                CoinToss();
            }
            else if (ParticipationAnswer == "StringManipulation")
            {
                StringManipulation();
            }
            else
            {
                All();
            }

            Console.ReadKey();
        }
        static void CoinToss()
        {
            Console.WriteLine("Heads? Or Tails? >>");
            string guessInputAsString = Console.ReadLine();
            int guessInput;

            if (guessInputAsString == "Heads")
            {
                guessInput = 0;
                Console.WriteLine("You guessed heads");
            }
            else
            {
                guessInput = 1;
                Console.WriteLine("You guessed Tails");
            }

            Random rand = new Random();
            int randomNumber = rand.Next(0, 2);

            if (randomNumber == 0)
            {
                Console.WriteLine("The coin landed on Heads");
            }
            else
            {
                Console.WriteLine("The coin landed on Tails");
            }
            if (guessInput == randomNumber)
            {
                Console.WriteLine("You guessed correctly");
            }
            else
            {
                Console.WriteLine("You guessed wrong");
            }

            Console.ReadKey();
        }

        static void StringManipulation ()
        {
            string ProgrammingMessage = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(ProgrammingMessage);
            Console.WriteLine("What words do you want to search for in the sentance above?");
            string SearchFor = Console.ReadLine();
            Console.WriteLine("What words do you want to change?");
            string ReplaceWith = Console.ReadLine();

            bool DoesitContain = ProgrammingMessage.Contains(SearchFor);

            string ReverReverse = SearchFor.Substring(0, SearchFor.Length);
            ReverReverse = "        " + ReverReverse + "        ";
            ReverReverse = ReverReverse.Trim();


            if (DoesitContain == true)
            {
                Console.WriteLine(ProgrammingMessage.Replace(SearchFor, ReplaceWith));
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {SearchFor}");
                for (int i = SearchFor.Length - 1; i >= 0; i--)
                {
                    Console.Write(SearchFor[i]);
                }
            }

            Console.ReadKey();
        }
        static void All ()
        {
            CoinToss();
            StringManipulation();

        }
    }
}
