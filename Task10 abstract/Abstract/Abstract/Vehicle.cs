using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public abstract void ShowInfo();

        protected Vehicle(string color, int year)
        {
            Year = year;
            Color = color;
        }
    }
}
