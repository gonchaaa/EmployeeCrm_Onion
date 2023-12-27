using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.InternshipException
{
    public class InternshipNotFoundException : Exception
    {
        public InternshipNotFoundException() : base("Event not found")
        {
        }

        public InternshipNotFoundException(string? message) : base(message)
        {
        }

        public InternshipNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
