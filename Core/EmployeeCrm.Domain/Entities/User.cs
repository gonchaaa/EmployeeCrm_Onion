using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities;
public class User : BaseEntity
{
    public string UserName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string PasswordRepeat { get; set; }
    public int PositionId { get; set; }
    public Position Position { get; set; }
}