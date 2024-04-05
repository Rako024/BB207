using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    internal class Product
    {
        private static int _no;
        public int No { get;}
        public string Name { get; set; }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { if (value > 0)
                    _price = value;
                else
                    Console.WriteLine("Price menfi ola bilmez");
            }
        }
        public string Type { get; set; }
        public int Count { get; set; }

        public Product(string name, int price, string type, int count)
        {
            No = ++_no;
            Name = name;
            Price = price;
            Type = type;
            Count = count;
        }

        public override string ToString()
        {
            return $"No = {No}, Name = {Name}, Price = {Price}, Type = {Type}, Count = {Count}";
        }

    }
}
