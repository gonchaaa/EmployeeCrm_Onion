using EmployeeCrm.Application.Repositories.InformationList;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.InformationList
{
    public class InformationListReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.InformationList>, IInformationListReadRepository
    {
        public InformationListReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
