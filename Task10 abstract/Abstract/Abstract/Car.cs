using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Car:Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }

        private int _maxSpeed;

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set 
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    Console.WriteLine("INPUT ERROR!");
                }
            }
        }

        public Car(string color, int year, string brad, string model, int maxSpeed):base(color, year)
        {
            Brand = brad;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brad = {Brand}, Model = {Model}, Max speed = {MaxSpeed}, Color = {Color}, Year = {Year}");
        }
    }
}
