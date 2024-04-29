using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_ADO_app.Exceptions
{
    internal class NotFounIdException:Exception
    {
        public NotFounIdException(string message = "Id not found"):base(message)
        {
            
        }
    }
}
