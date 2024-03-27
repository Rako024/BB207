using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Encaplusation
{
    internal class Product
    {
		private double _price;
		private int _count;
		public int No;
		public string Name;

		public double Price
		{
			get { return _price; }
			set 
			{
				if(value < 0)
				{
                    Console.WriteLine("Price menfi ede ola bilmez!!!");
                }else
				{
					_price = value;
				}
			
			}
		}

		public int Count {
			get { return _count; }
			set 
			{
				if(value < 0 )
				{
                    Console.WriteLine("Kitablarin sayi menfi ola bilmez");
				}
				else
				{
					_count = value;
				}
			}
		}

        public Product(double price, int count, int no, string name)
        {
            Price = price;
			Count = count;
			No = no;
			Name = name;
        }

    }
}
