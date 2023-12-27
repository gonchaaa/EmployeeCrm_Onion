using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.StudentPaymentException
{
    public class StudentPaymentNotFoundException : Exception
    {
        public StudentPaymentNotFoundException() : base("Event not found")
        {
        }

        public StudentPaymentNotFoundException(string? message) : base(message)
        {
        }

        public StudentPaymentNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
