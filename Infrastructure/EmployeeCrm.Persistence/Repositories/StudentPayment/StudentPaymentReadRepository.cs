using EmployeeCrm.Application.Repositories.StudentPayment;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.StudentPayment
{
    public class StudentPaymentReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.StudentPayment>, IStudentPaymentReadRepository
    {
        public StudentPaymentReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
