using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Repositories.Employee;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Employee
{
    public class EmployeeWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Employee>, IEmployeeWriteRepository
    {
        public EmployeeWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
