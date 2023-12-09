using EmployeeCrm.Application.Repositories.Message;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Message
{
    public class MessageWriteRepository : WriteRepository<EmployeeCrm.Domain.Entities.Message>, IMessageWriteRepository
    {
        public MessageWriteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
