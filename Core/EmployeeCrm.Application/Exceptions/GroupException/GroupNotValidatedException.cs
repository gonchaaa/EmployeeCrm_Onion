using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.GroupException
{
    public class GroupNotValidatedException : Exception
    {
        public GroupNotValidatedException() : base("Butun xanalari doldurun.")
        {
        }

        public GroupNotValidatedException(string message) : base(message)
        {
        }

        public GroupNotValidatedException(string message, Exception e) : base(message, e)
        {
        }
    }
}
