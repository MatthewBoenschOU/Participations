using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word and I'll tell you if it's a palindrone or not");
            string WordInput = Console.ReadLine().ToLower();

            string Reverse = "";

            for (int i = WordInput.Length-1; i >= 0; i--)
            {
                Reverse += WordInput[i];
            }

            Console.WriteLine(Reverse);
            
            Console.ReadKey();


        }
    }
}
