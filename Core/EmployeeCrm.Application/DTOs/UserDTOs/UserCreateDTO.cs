using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.UserDTOs
{
    public class UserCreateDTO
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public int PositionId { get; set; }
    }
}
