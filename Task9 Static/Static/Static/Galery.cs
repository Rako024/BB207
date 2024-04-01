using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Galery
    {
        private static int _id = 0;
        public int Id;
        public string Name;
        public Car[] Cars = { };

        public Galery(string name)
        {
            Name = name;
            Id = _id++;
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }

        public Car[] GetAllCars()
        {
            return Cars;
        }

        public void ShowAllCars()
        {
            foreach (var item in Cars)
            {
                item.ShowInfo();
            }
        }

        public Car FindCarById(int id)
        {
            foreach (var item in Cars)
            {
                if (item.Id == id) return item;
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            foreach (var item in Cars)
            {
                if (item.CarCode == carCode) return item;
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] cars = { };
            foreach(var item in Cars)
            {
                if(item.Speed>=minSpeed && item.Speed <= maxSpeed)
                {
                    Array.Resize(ref cars, cars.Length + 1);
                    cars[cars.Length - 1] =(Car)item;
                }
            }
            return cars;
        }
    }
}
