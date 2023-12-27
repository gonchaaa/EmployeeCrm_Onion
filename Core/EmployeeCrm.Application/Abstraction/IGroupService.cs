using EmployeeCrm.Application.DTOs.GroupDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IGroupService
    {
        Task CreateGroup(GroupCreateDTO groupCraeteDTO);
        Task UpdateGroup(GroupUpdateDTO groupCraeteDTO);
        List<GroupDTO> GetGroups();
        GroupDTO GetGroupById(int id);
    }
}
