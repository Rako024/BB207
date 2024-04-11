using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student (string name, string surname)
        {
            Id = ++_id;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"Id = {Id}; Name = {Name}; Surname = {Surname}";
        }
    }
}
