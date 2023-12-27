using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities;
public class RegisterBlank : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public string Speciality { get; set; }
    public string Email { get; set; }
    public int PhoneNum { get; set; }
    public LessonTime lessonTime { get; set; }
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }
    public int InformationListId { get; set; }
    public InformationList InformationList { get; set; }

}
public enum LessonTime
{
    Morning,
    Afternoon,
    Evening
} 