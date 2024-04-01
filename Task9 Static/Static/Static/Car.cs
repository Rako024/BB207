using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Car
    {
        private static int _id = 1000;
        public int Id;
        public string Name { get; set; }
        public int Speed { get; set; }
        public string CarCode { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
            _id++;
            Id = _id;
            CarCode = char.ToUpper(Name[0]).ToString() + char.ToUpper(Name[1]).ToString()+ _id.ToString();
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Id,-4} {CarCode,-6} {Name,-15} {Speed,-5}");
        }



    }
}
