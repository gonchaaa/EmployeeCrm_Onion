using EmployeeCrm.Application.Repositories.Position;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Position
{
    public class PositionWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Position>, IPositionWriteRepository
    {
        public PositionWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
