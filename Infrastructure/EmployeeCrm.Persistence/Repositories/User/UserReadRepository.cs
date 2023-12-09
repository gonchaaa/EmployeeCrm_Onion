using EmployeeCrm.Application.Repositories.User;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.User
{
    public class UserReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.User>, IUserReadRepository
    {
        public UserReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
