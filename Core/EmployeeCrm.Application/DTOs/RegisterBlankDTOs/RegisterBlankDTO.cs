using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.RegisterBlankDTOs
{
    public class RegisterBlankDTO
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int InformationListId { get; set; }
    }
}
