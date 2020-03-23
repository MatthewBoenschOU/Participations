using System;

namespace HW4VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string Message = Console.ReadLine().ToLower();

            int VowelCount =0;
            int ConsonantCount=0;

            if (Message.Contains('a') || Message.Contains('e') || Message.Contains('i') || Message.Contains('o') || Message.Contains('u') || Message.Contains('y'))
            {
                VowelCount++;
            }

            string NoSpaceMessage = Message.Replace(" ","");

            ConsonantCount = NoSpaceMessage.Length - VowelCount;
            
            Console.WriteLine($"I counted {VowelCount} vowels and {ConsonantCount} consonants");

            Console.ReadKey();
        }
    }
}
