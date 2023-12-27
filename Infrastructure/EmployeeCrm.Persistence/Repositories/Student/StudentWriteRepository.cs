using EmployeeCrm.Application.Repositories.Student;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Student
{
    public class StudentWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Student>, IStudentWriteRepository
    {
        public StudentWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
