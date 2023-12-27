using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeCrm.Domain.Entities;
public class StudentPayment : BaseEntity
{
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }
    public decimal Amount { get; set; }

}