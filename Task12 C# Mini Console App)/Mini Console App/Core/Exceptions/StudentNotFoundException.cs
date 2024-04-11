using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string message = "No student with ID found"):base(message) { }
    }
}
