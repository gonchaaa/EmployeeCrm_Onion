using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.ExpenseTypeException
{
    public class ExpenseTypeNotFoundException : Exception
    {
        public ExpenseTypeNotFoundException() : base("Event not found")
        {
        }

        public ExpenseTypeNotFoundException(string? message) : base(message)
        {
        }

        public ExpenseTypeNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
