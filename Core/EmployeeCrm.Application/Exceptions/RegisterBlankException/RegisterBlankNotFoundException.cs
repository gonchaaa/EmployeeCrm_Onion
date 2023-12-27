using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.RegisterBlankException
{
    public class RegisterBlankNotFoundException : Exception
    {
        public RegisterBlankNotFoundException() : base("Event not found")
        {
        }

        public RegisterBlankNotFoundException(string? message) : base(message)
        {
        }

        public RegisterBlankNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
