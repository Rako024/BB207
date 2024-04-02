namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[5];
            Car car1 = new Car("DarkBlue",2005,"BMW","525d",260);
            Car car2 = new Car("DarkGreen", 2000, "Mercedes-Benz", "W210 E220", 260);
            Car car3 = new Car("PianoBlack", 2016, "Hundai", "i30", 240);
            Bus bus1 = new Bus("Pink",2018,28);
            Bus bus2 = new Bus("Red",2007,33);

            vehicles[0] = car1;
            vehicles[1] = car2;
            vehicles[2] = car3;
            vehicles[3] = bus1;
            vehicles[4] = bus2;

            foreach(var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }
        }
    }
}
