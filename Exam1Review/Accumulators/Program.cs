using System;

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            int Add = 0;
            double Multiply = 1;

            for (int i = 1; i < 5; i++)
            {
                Add += i;
                Multiply *= i;
            }
            Console.WriteLine(Add);
            Console.WriteLine(Multiply);
        }
    }
}
