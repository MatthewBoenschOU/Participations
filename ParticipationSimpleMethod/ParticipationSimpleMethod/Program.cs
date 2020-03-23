using System;

namespace ParticipationSimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string Animal = "";
            string Noise = "";


            Console.WriteLine("Please enter a type on animal");
            Animal = Console.ReadLine();
            Noise = Sound(Animal);
            Console.WriteLine(Noise);
            Console.ReadKey();

        }
        static string Sound (string Animal)
        {
            string Sound = "";
            
            if (Animal == "Cow" || Animal == "cow")
            {
                Sound = "Moo";
            }
            else if (Animal == "Lion" || Animal =="lion")
            {
                Sound = "roar";
            }
            else if (Animal == "Duck" || Animal == "duck")
            {
                Sound = "quack";
            }
            else if (Animal == "Cat" || Animal == "cat")
            {
                Sound = "meaow";
            }
            else if (Animal == "Dog" || Animal == "dog")
            {
                Sound = "woof";
            }
            else
            {
                Sound = "not valid animal";
            }
            return Sound;

        }

    }
}
