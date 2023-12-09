using EmployeeCrm.Application.Repositories.ExpenseType;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.ExpenseType
{
    public class ExpenseTypeWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.ExpenseType>, IExpenseTypeWriteRepository
    {
        public ExpenseTypeWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
