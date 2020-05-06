using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> NumberList = new List<double>();

            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number");
                NumberList.Add(Convert.ToDouble(Console.ReadLine()));
            }
                       
                      

            Console.WriteLine($"The max number you inputed was {MAX(NumberList).ToString("N2")}");
            Console.WriteLine($"The average of all of the numbers you inputed is {Average(NumberList).ToString("N2")}");

            Console.ReadKey();

                      

            
        }
        static double MAX(List<double> M1)
        {
            double MaxNum = 0;

            for (int i = 0; i < M1.Count(); i++)
            {
                if (M1[i] > MaxNum)
                {
                    MaxNum = M1[i];
                }
                
            }
            return MaxNum;
        }
        static double Average (List<double> V1)
        {
            double Sum = 0;
            double AVG = 0;

            for (int i = 0; i < V1.Count(); i++)
            {
                Sum += V1[i];
            }

            AVG = Sum / V1.Count();

            return AVG;
            
        }
    }
}
