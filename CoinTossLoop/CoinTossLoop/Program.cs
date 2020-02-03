using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTossLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int RandomNumber = 1;
            int UserGuess = -1;

            while (UserGuess != RandomNumber)

            {
                RandomNumber = rand.Next(0, 2);
                Console.WriteLine(RandomNumber);

                Console.WriteLine("Enter heads or Tails)";
                string UserGuessAsString = Console.ReadLine();
                
                const int Heads_Value = 0;
                const int Tails_Value = 1;

                if (UserGuessAsString == "Heads");
                else if (UserGuessAsString == "Tails");
                else

            }
            
            

        }
    }
}
