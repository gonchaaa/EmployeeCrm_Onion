using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities;
public class Employee : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime StartWork { get; set; }
    public DateTime Present { get; set; }
}