using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class UserAttendance : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Lesson Lesson { get; set; }
        public int LessonId { get; set; }
        public bool Attendance { get; set; }
    }
}
