using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.LessonException
{
    public class LessonNotFoundException : Exception
    {
        public LessonNotFoundException() : base("Event not found")
        {
        }

        public LessonNotFoundException(string? message) : base(message)
        {
        }

        public LessonNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
