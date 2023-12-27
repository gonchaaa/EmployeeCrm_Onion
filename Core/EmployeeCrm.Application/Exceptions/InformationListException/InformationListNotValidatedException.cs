using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.InformationListException
{
    public class InformationListNotValidatedException : Exception
    {
        public InformationListNotValidatedException() : base("Butun xanalari doldurun.")
        {
        }

        public InformationListNotValidatedException(string message) : base(message)
        {
        }

        public InformationListNotValidatedException(string message, Exception e) : base(message, e)
        {
        }
    }
}
