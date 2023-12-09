using EmployeeCrm.Application.Repositories.RegisterBlank;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.RegisterBlank
{
    public class RegisterBlankReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.RegisterBlank>, IRegisterBlankReadRepository
    {
        public RegisterBlankReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
