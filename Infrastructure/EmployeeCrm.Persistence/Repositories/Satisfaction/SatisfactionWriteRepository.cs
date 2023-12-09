using EmployeeCrm.Application.Repositories.Satisfaction;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Satisfaction
{
    public class SatisfactionWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Satisfaction>, ISatisfactionWriteRepository
    {
        public SatisfactionWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
