using EmployeeCrm.Application.DTOs.İnformationListDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IInformationListService
    {
        Task<InformationListCreateDTO> CreateInformation(InformationListCreateDTO informationListCreateDTO);
        Task<InformationListUpdateDTO> UpdateInformationList(InformationListUpdateDTO informationListUpdateDTO);
        List<InformationListDTO> GetInformationList();
        InformationListDTO GetInformationById(int id);

    }
}
