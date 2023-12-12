using EmployeeCrm.Application.Repositories.Task;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Task
{
    public class TaskWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Task>, ITaskWriteRepository
    {
        public TaskWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
