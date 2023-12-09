using EmployeeCrm.Application.Repositories.Meeting;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Meeting
{
    public class MeetingReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Meeting>, IMeetingReadRepository
    {
        public MeetingReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
