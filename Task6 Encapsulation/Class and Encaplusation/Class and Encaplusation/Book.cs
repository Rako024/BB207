    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Encaplusation
{
    internal class Book:Product
    {
        public string Genre;

        public Book(double price, int count, int no, string name, string genre):base(price, count, no, name)
        {
            Genre = genre;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"{Name,-15} {Price,-8} {Count,-5} {No,-8} {Genre,-15}");
        }
    }
}
