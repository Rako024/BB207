using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    internal class Person
    {
        private static int _id;
        public int Id { get; }
        public string FullName { get; set; }
        private sbyte _age;

        public sbyte Age
        {
            get { return _age; }
            set { if(value>0 &&  value<=125)
                        _age = value;
                    else
                    Console.WriteLine("Age menfi ve ya 125 den yuxari ola bilmez");
            }
        }
        public int Cash { get; set; }

        public Person(string fullName, sbyte age, int Cash)
        {
            Id = ++_id;
            FullName = fullName;
            Age = age;
            Cash = Cash;
        }
        public override string ToString()
        {
            return $"id = {Id}, FullName = {FullName}, Age = {Age}, Cash = {Cash}";
        }


    }
}
