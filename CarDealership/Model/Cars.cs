using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Model
{
    public class Cars


    {
        public Cars(int id, string make, string model, int year, string color)
        {
            ID = id;
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public Cars()
        { }
        public int ID {get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
