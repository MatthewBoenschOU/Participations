using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attempt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserAnswer = "";
            string UserAnswer2 = "";
            double Calculation = 0;
            double Calculation2 = 0;

            do
            {
                Console.WriteLine("What type of calculation do you want to perform? A/S/M/D");
                string CalculationType = Console.ReadLine();

                Console.WriteLine("Please enter a number");
                double Num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter another number");
                double Num2 = Convert.ToDouble(Console.ReadLine());

                if (CalculationType == "A")
                {
                    Calculation = Add(Num1, Num2);
                    Console.WriteLine($"The sum of your inputs is {Calculation}");
                }
                else if (CalculationType == "S")
                {
                    Calculation = Subtract(Num1, Num2);
                    Console.WriteLine($"The difference of your inputs is {Calculation}");

                }
                else if (CalculationType == "M")
                {
                    Calculation = Multiply(Num1, Num2);
                    Console.WriteLine($"The product of your inputs is {Calculation}");
                }
                else if (CalculationType == "D")
                {
                    Calculation = Divide(Num1, Num2);
                    Console.WriteLine($"The quotient of your inputs is {Calculation}");
                }

                Console.WriteLine("Would you like to do another calculation? (A) Would you like to use your answer as an input for another calculation? (B) Would you like to exit? (C)");
                UserAnswer = Console.ReadLine();

            } while (UserAnswer == "A");

            
            if (UserAnswer == "B")
            {


                Console.WriteLine("What type of calculation do you want to perform? A/S/M/D");
                string CalculationType2 = Console.ReadLine();

                Console.WriteLine("Please enter a number");
                double Num3 = Convert.ToDouble(Console.ReadLine());

                if (CalculationType2 == "A")
                {
                    Calculation2 = Add(Calculation, Num3);
                    Console.WriteLine($"The sum of your inputs is {Calculation2}");
                }
                if (CalculationType2 == "S")
                {
                    Calculation2 = Subtract(Calculation, Num3);
                    Console.WriteLine($"The sum of your inputs is {Calculation2}");
                }
                if (CalculationType2 == "M")
                {
                    Calculation2 = Multiply(Calculation, Num3);
                    Console.WriteLine($"The sum of your inputs is {Calculation2}");
                }
                if (CalculationType2 == "D")
                {
                    Calculation2 = Divide(Calculation, Num3);
                    Console.WriteLine($"The sum of your inputs is {Calculation2}");
                }

                Console.WriteLine("Would you like to do another calculation? (A) Would you like to use your answer as an input for another calculation? (B) Would you like to exit? (C)");
                UserAnswer2 = Console.ReadLine();

            }
            if (UserAnswer == "C")
            {
                Console.WriteLine("Thanks for using my program! <3");
            }
            

            Console.ReadKey();
        }
        static void DeveloperInformation(string DeveloperName, string ClassName, string DateOfWriting)
        {
            Console.WriteLine($"{DeveloperName} wrote this application for {ClassName} on {DateOfWriting}");
        }
        static double Add(double first, double second)
        {
            return first + second;
        }
        static double Subtract(double N1, double N2)
        {
            return N1 - N2;
        }
        static double Multiply(double Number1, double Number2)
        {
            return Number1 * Number2;
        }
        static double Divide(double one, double two)
        {
            return one / two;
        }
    }
}

