using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationParticipation
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
