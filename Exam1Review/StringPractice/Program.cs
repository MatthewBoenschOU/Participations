using System;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message");
            string Message = Console.ReadLine();

            int lastletter;

            lastletter = Message.Length - 1;

            Console.WriteLine(lastletter);
            
            Console.ReadKey();

        }
    }
}
