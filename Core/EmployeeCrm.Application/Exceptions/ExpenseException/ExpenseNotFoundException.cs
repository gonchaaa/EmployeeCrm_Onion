using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.ExpenseException
{
    public class ExpenseNotFoundException : Exception
    {
        public ExpenseNotFoundException() : base("Event not found")
        {
        }

        public ExpenseNotFoundException(string? message) : base(message)
        {
        }

        public ExpenseNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
