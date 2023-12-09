using EmployeeCrm.Application.Repositories.Lesson;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Lesson
{
    public class LessonWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Lesson>, ILessonWriteRepository
    {
        public LessonWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
