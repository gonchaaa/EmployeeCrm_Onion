using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.MeetingException
{
    public class MeetingNotFoundException : Exception
    {
        public MeetingNotFoundException() : base("Event not found")
        {
        }

        public MeetingNotFoundException(string? message) : base(message)
        {
        }

        public MeetingNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
