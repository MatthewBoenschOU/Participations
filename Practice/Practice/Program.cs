using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            static double SecretCalculatio (int value1, int value2)
            {
                value1 = 5;
                value2 = 15;
                return value1 + value2;
                return value2 - value1;
                return value2 / value2;
            }

            int v1 = 5;
            int v2 = 15;

            Console.WriteLine(SecretCalculatio(v1, v2));
        }
    }
}
