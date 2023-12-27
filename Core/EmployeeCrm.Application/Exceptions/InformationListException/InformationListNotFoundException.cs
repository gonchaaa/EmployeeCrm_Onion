using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.InformationListException
{
    public class InformationListNotFoundException : Exception
    {
        public InformationListNotFoundException() : base("Event not found")
        {
        }

        public InformationListNotFoundException(string? message) : base(message)
        {
        }

        public InformationListNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
