using System;

namespace HW2FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string NumberInput = Console.ReadLine();

            bool Check = Int32.TryParse(NumberInput, out int Number);

            if (Check == false)
            {
                Console.WriteLine("You don goofed");
            }
            else
            {
                if (Number % 5 ==0 && Number % 3==0)
                {
                    Console.WriteLine($"Yo! {Number} FizzBuzz");
                }
                else if (Number % 5 == 0)
                {
                    Console.WriteLine($"Yo! {Number} Fizz");
                }
                else if (Number % 3 == 0)
                {
                    Console.WriteLine($"Yo! {Number} Buzz");
                }
            }



            Console.ReadKey();
        }
    }
}
