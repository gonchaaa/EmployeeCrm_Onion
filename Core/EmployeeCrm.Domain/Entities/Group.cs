using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeCrm.Domain.Entities;
public class Group : BaseEntity
{
    public string GroupNumber { get; set; }
    public bool IsActive { get; set; }
}