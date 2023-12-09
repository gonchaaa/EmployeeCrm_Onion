using EmployeeCrm.Application.Repositories.Role;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Role
{
    public class RoleReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Role>, IRoleReadRepository
    {
        public RoleReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
