﻿using EmployeeCrm.Application.Repositories.Position;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Position
{
    public class PositionReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Position>, IPositionReadRepository
    {
        public PositionReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
