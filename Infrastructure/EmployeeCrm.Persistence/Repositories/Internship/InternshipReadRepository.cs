using EmployeeCrm.Application.Repositories.Internship;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Internship
{
    public class InternshipReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Internship>, IInternshipReadRepository
    {
        public InternshipReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
