using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a month");
            string MonthInput = Console.ReadLine();

            



            if (MonthInput.ToLower() == "january")
            {
                Console.WriteLine($"The month of {MonthInput} has 31 days");
            }
            else if (MonthInput.ToLower() == "february")
            {
                Console.WriteLine("Is it a leap year? Y/N");
                string LeapYear = Console.ReadLine();
                do
                {
                    if (LeapYear.ToUpper() == "Y")
                    {
                        Console.WriteLine($"The month of {MonthInput} has 29 days");
                    }
                    else if (LeapYear == "N")
                    {
                        Console.WriteLine($"The month of {MonthInput} has 28 days");
                    }
                    else
                    {
                        Console.WriteLine("Please input a valid answer (Y/N))");
                    }
                } while (LeapYear != "Y" || LeapYear != "N");
            }
            else if (MonthInput.ToLower() == "march")
            {
                Console.WriteLine($"The month of {MonthInput} has 31 days");
            }
            else if (MonthInput.ToLower() == "april")
            {
                Console.WriteLine($"The month of {MonthInput} has 30 days");
            }
            else if (MonthInput.ToLower() == "may")
            {
                Console.WriteLine($"The month of {MonthInput} has 31 days");
            }
            else if (MonthInput.ToLower() == "june")
            {
                Console.WriteLine($"The month of {MonthInput} has 30 days");
            }
            else if (MonthInput.ToLower() == "july")
            {
                Console.WriteLine($"The month of {MonthInput} has 31 days");
            }
            else if (MonthInput.ToLower() == "august")
            {
                Console.WriteLine($"The month of {MonthInput} has 31 days");
            }
            else if (MonthInput.ToLower() == "september")
            {
                Console.WriteLine($"The month of {MonthInput} has 30 days");
            }
            else if (MonthInput.ToLower() == "october")
            {
                Console.WriteLine($"The month of {MonthInput} has 31 days");
            }
            else if (MonthInput.ToLower() == "november")
            {
                Console.WriteLine($"The month of {MonthInput} has 30 days");
            }
            else if (MonthInput.ToLower() == "december")
            {
                Console.WriteLine($"The month of {MonthInput} has 31 days");
            }
            else
            {
                Console.WriteLine("Please enter a valid month");
            }
                
            }
        }
    }

