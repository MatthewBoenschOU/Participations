using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSumming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to count to?");
            int Threshold = Convert.ToInt32(Console.ReadLine());
            //Could also do i<101
            for (int i = 1; i <= Threshold; i++)
            {
                Console.Write(i + " ");
            }

            double Sum = 0; //accumulator variable
            string Answer;
            Console.WriteLine();

            do
            {
                Console.WriteLine("Please give us a number to add");
                int Number = Convert.ToInt32(Console.ReadLine());
                //sum = sum + number;
                Sum += Number;


                Console.WriteLine("Do you have another number to add? (y,n)");
                Answer = Console.ReadLine();

            } while (Answer == "y");
            //Or you could do "while (answer != "n")
            Console.WriteLine($"Your summation of values is {Sum.ToString("N2"))"};
            Console.ReadKey();
        }
    }
}
