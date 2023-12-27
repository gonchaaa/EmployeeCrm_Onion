using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.İnternshipDTOs
{
    public class InternshipCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LessonId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
