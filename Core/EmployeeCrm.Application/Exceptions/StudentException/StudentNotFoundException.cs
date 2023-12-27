using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.StudentException
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException() : base("Event not found")
        {
        }

        public StudentNotFoundException(string? message) : base(message)
        {
        }

        public StudentNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
