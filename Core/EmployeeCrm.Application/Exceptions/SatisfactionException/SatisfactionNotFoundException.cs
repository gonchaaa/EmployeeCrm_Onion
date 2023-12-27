using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.SatisfactionException
{
    public class SatisfactionNotFoundException : Exception
    {
        public SatisfactionNotFoundException() : base("Event not found")
        {
        }

        public SatisfactionNotFoundException(string? message) : base(message)
        {
        }

        public SatisfactionNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
