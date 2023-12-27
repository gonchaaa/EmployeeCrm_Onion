using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs.EventDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Services
{
    public class EventService : IEventService
    {
        public Task CreateEvent(CreateEventDTO createEventDTO)
        {
            throw new NotImplementedException();
        }

        public List<EventListDTO> GetEvents()
        {
            throw new NotImplementedException();
        }
    }
}
