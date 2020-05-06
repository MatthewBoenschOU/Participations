using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car AutoMobile = new Car();

            AutoMobile.Manufacturer = "Mercedes";
            AutoMobile.Year = 2011;
            AutoMobile.Model = "E350";

            Console.WriteLine($"You own a {AutoMobile.Year} {AutoMobile.Manufacturer} {AutoMobile.Model} automobile, is that correct?");

            Console.ReadKey();
        }
    }
}
