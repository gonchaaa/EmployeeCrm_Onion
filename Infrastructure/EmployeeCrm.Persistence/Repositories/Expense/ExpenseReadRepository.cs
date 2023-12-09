using EmployeeCrm.Application.Repositories.Expense;
using EmployeeCrm.Domain.Entities;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Expense
{
    public class ExpenseReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Expense>, IExpenseReadRepository
    {
        public ExpenseReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
