using EmployeeCrm.Application.Repositories.Satisfaction;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Satisfaction
{
    public class SatisfactionReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Satisfaction>, ISatisfactionReadRepository
    {
        public SatisfactionReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
