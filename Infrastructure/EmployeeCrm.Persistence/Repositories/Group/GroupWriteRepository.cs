using EmployeeCrm.Application.Repositories.Group;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Group
{
    public class GroupWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Group>, IGroupWriteRepository
    {
        public GroupWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
