using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs.EmployeeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task AddEmployee(EmployeeCreateDTO employeeCreateDTO)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDTO> GetByEmployeeId(string firstname)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(EmployeeUpdateDTO employeeUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
