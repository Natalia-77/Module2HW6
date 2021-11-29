using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Exceptions
{
    public class ServiceException : Exception
    {
        public ServiceException(string message)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
