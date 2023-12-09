using EmployeeCrm.Application.Repositories.Message;
using EmployeeCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Repositories.Message
{
    public class MessageReadRepository : ReadRepository<EmployeeCrm.Domain.Entities.Message>, IMessageReadRepository
    {
        public MessageReadRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
