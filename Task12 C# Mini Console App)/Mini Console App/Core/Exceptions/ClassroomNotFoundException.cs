using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class ClassroomNotFoundException: Exception
    {
        public ClassroomNotFoundException(string message = "Classroom not foud"):base(message) { }
    }
}
