using System;

namespace DaysInTheMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a month");
            string MonthInput = Console.ReadLine().ToLower();


            

            if (MonthInput == "january" || MonthInput == "march" || MonthInput == "may" || MonthInput == "july" || MonthInput == "august" || MonthInput == "october" || MonthInput == "december")
            {
                Console.WriteLine($"There are 31 days in {MonthInput}" );
            }
            else if (MonthInput == "april" || MonthInput == "june" || MonthInput == "september" || MonthInput == "november")
            {
                Console.WriteLine($"There are 30 days in {MonthInput}");
            }
            else if (MonthInput == "february")
            {
                Console.WriteLine("Is it currently a leap year? Y/N");
                string LeapYear = Console.ReadLine();
                if (LeapYear.ToLower() == "y" || LeapYear.ToLower() == "yes")
                {
                    Console.WriteLine($"There are 29 days in {MonthInput}");
                }
                else
                {
                    Console.WriteLine($"THere are 28 days in {MonthInput}");
                }
            }
            Console.ReadKey();
        }
    }
}
