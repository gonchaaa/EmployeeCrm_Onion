using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeCrm.Application.Responses.CONCRETE.SUCCESSRESULTS
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(true, message)
        {
        }
    }
}

