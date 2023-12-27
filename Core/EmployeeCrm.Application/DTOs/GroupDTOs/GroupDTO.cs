using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.GroupDTOs
{
    public class GroupDTO
    {
        public int Id { get; set; }
        public string GroupNumber { get; set; }
        public string EmployeeId { get; set; }
    }
}
