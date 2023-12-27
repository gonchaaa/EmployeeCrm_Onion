using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.LessonException
{
    public class LessonNotValidatedException : Exception
    {
        public LessonNotValidatedException() : base("Butun xanalari doldurun.")
        {
        }

        public LessonNotValidatedException(string message) : base(message)
        {
        }

        public LessonNotValidatedException(string message, Exception e) : base(message, e)
        {
        }
    }
}
