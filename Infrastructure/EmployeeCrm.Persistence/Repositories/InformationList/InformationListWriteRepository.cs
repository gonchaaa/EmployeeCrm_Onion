using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Repositories.InformationList;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.InformationList
{
    public class InformationListWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.InformationList>, IInformationListWriteRepository
    {
        public InformationListWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
