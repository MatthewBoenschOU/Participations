using System;

namespace HW1SaleTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What're ya buyin?");
            string Item = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"How many {Item} do you want to buy?");
            double  Quantity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"How much per {Item}");
            double Price = Convert.ToDouble(Console.ReadLine());

            double Subtotal = Quantity * Price;
            double tax = .085 * Subtotal;
            double TotalTotal = Subtotal + tax;
            Console.WriteLine($"Your subtotal is {Subtotal}");
            Console.WriteLine($"Your salestax is {tax}");
            Console.WriteLine($"Your total is {TotalTotal}");

            Console.ReadKey();


        }
    }
}
