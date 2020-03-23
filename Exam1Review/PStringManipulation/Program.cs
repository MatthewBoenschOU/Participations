using System;

namespace PStringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(Message);

            Console.WriteLine("Wha do you want to search for?");
            string SearchFor = Console.ReadLine();

            Console.WriteLine("What do you want to replace?");
            string ReplaceWith = Console.ReadLine();

            string Reverse = "";

            if (Message.Contains(SearchFor))
            {
                Message = Message.Replace(SearchFor, ReplaceWith);
                Console.WriteLine(Message);
            }
            else
            {
                for (int i = SearchFor.Length-1; i >= 0; i--)
                {
                    Reverse += Message[i];
                }
                Console.WriteLine($"Sorry, I couldn't find {SearchFor} in the sentence, but here's this instead {Reverse}");
            }

            Console.ReadKey();



        }
    }
}
