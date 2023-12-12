using AutoMapper;
using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs.EventDTOs;
using EmployeeCrm.Application.Exceptions.EventException;
using EmployeeCrm.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence.Services
{
    public class EventService : IEventService
    {
        private readonly IEventReadRepository _eventReadRepository;
        private readonly IEventWriteRepository _eventWriteRepository;
        private readonly IMapper _mapper;
        public EventService(IEventReadRepository eventReadRepository, IEventWriteRepository eventWriteRepository, IMapper mapper)
        {
            _eventReadRepository = eventReadRepository;
            _eventWriteRepository = eventWriteRepository;
            _mapper = mapper;
        }

        public void CreateEvent(EventCreateDTO eventCreateDTO)
        {
            throw new NotImplementedException();
        }

        public List<EventDTO> GetEvents()
        {

            var events = _eventReadRepository.GetAll();
            if (events.Any()) throw new EventNotFoundException();
          var map=_mapper.Map<List<EventDTO>>(events);
            return map;
        }
    }
}
