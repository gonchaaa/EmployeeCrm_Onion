using EmployeeCrm.Application.Repositories.Lesson;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Lesson
{
    public class LessonReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Lesson>, ILessonReadRepository
    {
        public LessonReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
