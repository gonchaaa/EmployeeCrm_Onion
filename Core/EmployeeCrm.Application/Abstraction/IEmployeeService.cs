using EmployeeCrm.Application.DTOs.EmployeeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeCreateDTO employeeCreateDTO);
        Task UpdateEmployee(EmployeeUpdateDTO employeeUpdateDTO);
        List<EmployeeDTO> GetAll();
        EmployeeDTO GetByEmployeeId(int id);
    }
}
