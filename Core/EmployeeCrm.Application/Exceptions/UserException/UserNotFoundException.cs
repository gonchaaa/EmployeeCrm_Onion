using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.UserException
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("Event not found")
        {
        }

        public UserNotFoundException(string? message) : base(message)
        {
        }

        public UserNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
