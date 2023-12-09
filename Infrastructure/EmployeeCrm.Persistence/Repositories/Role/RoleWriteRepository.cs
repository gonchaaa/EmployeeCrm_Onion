using EmployeeCrm.Application.Repositories.Role;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Role
{
    public class RoleWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Role>, IRoleWriteRepository
    {
        public RoleWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
