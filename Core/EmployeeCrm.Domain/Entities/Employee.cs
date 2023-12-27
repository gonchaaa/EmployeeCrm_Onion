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
    public int UserId { get; set; }
    public User User { get; set; }
    public double? Salary { get; set; }
    public DateTime StartWork { get; set; }
    public DateTime Present { get; set; }

}