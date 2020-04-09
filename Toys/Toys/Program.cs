using System;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy Toy1 = new Toy();
            ToyBox ToyBox1 = new ToyBox();

            string ListTest = "";
            string Answer = "";

            do
            {
                Console.WriteLine("Please enter a toy");
                Toy1.Name = Console.ReadLine();
                
                Console.WriteLine($"Please enter the price of {Toy1.Name}");
                Toy1.Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Who is the manufacturer of {Toy1.Name}");
                Toy1.Manufacturer = Console.ReadLine();

                Console.WriteLine($"{Toy1.Name} (manufactured by {Toy1.Manufacturer} and costs {Toy1.Price.ToString("C2")}) is in aisle {Toy1.GetAisle()}");
                ToyBox1.Toys.Add(Toy1);

                Console.WriteLine("Would you like to look up another toy? (y/n)");
                Answer = Console.ReadLine();

            } while (Answer == "y");

            Console.WriteLine($"Here is what you have in your toy box {ToyBox1.Toys}");






        }
    }
}
