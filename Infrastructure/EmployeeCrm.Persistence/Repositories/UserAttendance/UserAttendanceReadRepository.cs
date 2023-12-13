using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Repositories.Attendance;
using EmployeeCrm.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories
{
    public class AttendanceReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Attendance>, IUserAttendanceReadRepository
    {
        public AttendanceReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
