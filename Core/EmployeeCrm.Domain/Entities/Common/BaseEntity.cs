using System;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities.Common;

public class BaseEntity
{

public int Id {get;set;}
public DateTime CreatedDate { get; set; }
public DateTime UpdatedDate { get; set; }
}