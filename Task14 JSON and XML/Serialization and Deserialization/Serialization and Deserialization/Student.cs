using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_and_Deserialization
{
    public class Student
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        public Student()
        {
            this.Id = ++_id;
        }

        public override string ToString()
        {
            return $"Id = {Id}  Name = {Name}  Surname = {Surname}  PhoneNumber = {PhoneNumber}  Email = {Email} Adress = {Adress}";
        }
    }
}
