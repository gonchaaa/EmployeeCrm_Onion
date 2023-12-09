using EmployeeCrm.Application.Repositories.User;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.User
{
    public class UserWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.User>, IUserWriteRepository
    {
        public UserWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
