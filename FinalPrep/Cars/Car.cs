using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Car
    {
        public string Manufacturer { get; set; }

        public int Year { get; set; }

        public string Model { get; set; }

        public Car()
        {
            Manufacturer = "";
            Year = 0;
            Model = "";
        }

        public Car (string manufacturer, int year, string model)
        {
            Manufacturer = manufacturer;
            Year = year;
            Model = model;
        }
    }
}
