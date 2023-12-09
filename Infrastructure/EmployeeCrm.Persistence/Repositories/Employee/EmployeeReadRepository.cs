using EmployeeCrm.Application.Repositories.Employee;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Employee
{
    public class EmployeeReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Employee>, IEmployeeReadRepository
    {
        public EmployeeReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
