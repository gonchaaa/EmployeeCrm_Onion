using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.PositionException
{
    public class PositionNotFoundException : Exception
    {
        public PositionNotFoundException() : base("Event not found")
        {
        }

        public PositionNotFoundException(string? message) : base(message)
        {
        }

        public PositionNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
