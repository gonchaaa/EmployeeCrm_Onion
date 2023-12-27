using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.DTOs.EventDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventDTO eventCreateDTO)
        {
            await _eventService.CreateEvent(eventCreateDTO);
            return Ok();
        }

        [HttpGet("events")]
        [Authorize]
        public async Task<IActionResult> GetAllEvents()
        {
            var result = _eventService.GetEvents();
            return Ok(result);
        }
    }
}
