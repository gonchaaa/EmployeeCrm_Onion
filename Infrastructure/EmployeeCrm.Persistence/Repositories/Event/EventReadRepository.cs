using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Event
{
    public class EventReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Event>, IEventReadRepository
    {
        public EventReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
