using EmployeeCrm.Application.Repositories.Lesson;
using EmployeeCrm.Application.Repositories.Meeting;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Meeting
{
    public class MeetingWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Meeting>, IMeetingWriteRepository
    {
        public MeetingWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
