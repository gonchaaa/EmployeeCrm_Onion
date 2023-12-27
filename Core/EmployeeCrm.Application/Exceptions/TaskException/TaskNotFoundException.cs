using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.TaskException
{
    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException() : base("Event not found")
        {
        }

        public TaskNotFoundException(string? message) : base(message)
        {
        }

        public TaskNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
