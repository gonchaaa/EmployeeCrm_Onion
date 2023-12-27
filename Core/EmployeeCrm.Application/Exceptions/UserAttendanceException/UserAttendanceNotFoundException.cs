using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.AttendanceException
{
    public class AttendanceNotFoundException : Exception
    {
        public AttendanceNotFoundException() : base("Event not found")
        {
        }

        public AttendanceNotFoundException(string? message) : base(message)
        {
        }

        public AttendanceNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
