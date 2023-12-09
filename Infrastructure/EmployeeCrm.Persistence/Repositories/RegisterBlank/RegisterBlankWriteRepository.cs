using EmployeeCrm.Application.Repositories.RegisterBlank;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.RegisterBlank
{
    public class RegisterBlankWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.RegisterBlank>, IRegisterBlankWriteRepository
    {
        public RegisterBlankWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
