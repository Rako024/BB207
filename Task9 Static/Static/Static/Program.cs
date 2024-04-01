namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Galery galery = new Galery("Gel Mala Qoyma Qala");
            Car car1 = new Car("Mercedes", 260);
            Car car2 = new Car("BMW", 320);

            galery.AddCar(car1);
            galery.AddCar(car2);
            galery.FindCarById(1001).ShowInfo();

            galery.ShowAllCars();

            galery.FindCarByCarCode("BM1002").ShowInfo();
        }
    }
}
