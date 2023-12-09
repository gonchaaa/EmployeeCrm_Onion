using EmployeeCrm.Application.Repositories.Internship;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Internship
{
    public class InternshipWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Internship>, IInternshipWriteRepository
    {
        public InternshipWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
