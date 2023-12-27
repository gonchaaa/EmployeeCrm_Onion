using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.RegisterBlankDTOs
{
    public class RegisterBlankUpdateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }
        public int PhoneNum { get; set; }
        public int LessonId { get; set; }
        public int InformationListId { get; set; }
    }
}
