using EmployeeCrm.Application.Repositories.Attendance;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories
{
    public class UserAttendanceWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.UserAttendance>, IUserAttendanceWriteRepository
    {
        public UserAttendanceWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
