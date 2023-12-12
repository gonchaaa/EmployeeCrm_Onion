using EmployeeCrm.Application.Repositories.Task;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Task
{
    public class TaskReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Task>, ITaskReadRepository
    {
        public TaskReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
