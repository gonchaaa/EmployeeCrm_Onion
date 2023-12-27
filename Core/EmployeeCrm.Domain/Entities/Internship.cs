using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class Internship : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

    }
}
