using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities;
public class Attendance : BaseEntity
{
    public DateTime LessonDate { get; set; }
    public bool IsAttendance { get; set; }
}