using EmployeeCrm.Application.Repositories.Student;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Student
{
    public class StudentReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Student>, IStudentReadRepository
    {
        public StudentReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
        