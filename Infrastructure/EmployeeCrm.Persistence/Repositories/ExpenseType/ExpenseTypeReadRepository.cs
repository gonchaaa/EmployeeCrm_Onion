using EmployeeCrm.Application.Repositories.ExpenseType;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.ExpenseType
{
    public class ExpenseTypeReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.ExpenseType>, IExpenseTypeReadRepository
    {
        public ExpenseTypeReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
