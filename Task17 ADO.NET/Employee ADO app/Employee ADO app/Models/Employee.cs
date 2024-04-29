using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_ADO_app.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}; Name:{Name}; Surname:{Surname}; Salary:{Salary}";
        }
    }
}
