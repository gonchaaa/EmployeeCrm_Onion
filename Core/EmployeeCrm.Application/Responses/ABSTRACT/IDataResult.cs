using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Responses.ABSTRACT
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; set; }
    }
}

