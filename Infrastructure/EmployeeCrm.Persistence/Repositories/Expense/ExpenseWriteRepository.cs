using EmployeeCrm.Application.Repositories.Expense;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Expense
{
    public class ExpenseWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Expense>, IExpenseWriteRepository
    {
        public ExpenseWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
