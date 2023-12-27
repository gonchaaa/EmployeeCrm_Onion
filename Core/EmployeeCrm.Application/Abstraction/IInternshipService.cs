using EmployeeCrm.Application.DTOs.İnternshipDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IInternshipService
    {
        Task<InternshipCreateDTO> CreateInternship(InternshipCreateDTO createDTO);
        Task<InternshipUpdateDTO> UpdateInternship(InternshipUpdateDTO updateDTO);

    }
}
