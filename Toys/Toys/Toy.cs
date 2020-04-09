using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    class Toy
    {
        

        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }

        
        public string GetAisle()
        {
            char FirstLetter = Manufacturer[0];
            string FirstLetterAsString = FirstLetter.ToString().ToUpper();
            Random rand = new Random();
            int Random = rand.Next(0, 24);
            string Output = FirstLetterAsString + Random.ToString();
            return Output;
        }


    }
}
