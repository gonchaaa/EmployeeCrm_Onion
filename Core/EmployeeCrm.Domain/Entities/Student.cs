using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities;
public class Student : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }
    public int IntructorId { get; set; }
    public Employee Employee { get; set; }
    public int StudenPaymentId { get; set; }
    public StudentPayment StudentPayment { get; set; }
    public bool Payment { get; set; }


}