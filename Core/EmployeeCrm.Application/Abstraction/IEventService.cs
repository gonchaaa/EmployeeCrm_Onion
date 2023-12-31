﻿using EmployeeCrm.Application.DTOs.EventDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IEventService
    {
        Task CreateEvent(CreateEventDTO createEventDTO);
        Task UpdateEvent(EventUpdateDTO updateEventDTO);
        List<EventListDTO> GetEvents();
        EventListDTO GetEventById(int id);
    }
}
