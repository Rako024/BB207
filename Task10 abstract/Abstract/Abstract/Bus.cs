using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Bus : Vehicle
    {
        private int _passengerCount;

        public int PassengerCount
        {
            get { return _passengerCount; }
            set { 
                if(value > 0)
                _passengerCount = value;
                else
                    Console.WriteLine("INPUT ERROR!");
            }
        }

        public Bus(string color, int year, int passengerCount):base(color,year)
        {
            PassengerCount = passengerCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Color = {Color}, Year = {Year}, Passenger Count = {PassengerCount}");
        }
    }
}
