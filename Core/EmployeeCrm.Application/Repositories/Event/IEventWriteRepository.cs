﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Repositories
{
    public interface IEventWriteRepository : IWriteRepository<EmployeeCrm.Domain.Entities.Event>
    {
    }
}
