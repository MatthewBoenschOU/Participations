using System;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message");
            string Message = Console.ReadLine();

            for (int i = 0; i < Message.Length; i=i+2)
            {
                char Position = Message[i];
                Console.WriteLine(Position);

            }
            
            Console.ReadKey();

        }
    }
}
