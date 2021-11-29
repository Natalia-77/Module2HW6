using System;
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
