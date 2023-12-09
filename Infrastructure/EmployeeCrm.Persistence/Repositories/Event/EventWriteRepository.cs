using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Event
{
    public class EventWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Event>, IEventWriteRepository
    {
        public EventWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
