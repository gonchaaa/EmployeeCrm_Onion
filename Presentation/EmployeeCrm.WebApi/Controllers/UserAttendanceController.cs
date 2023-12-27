using EmployeeCrm.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAttendanceController : ControllerBase
    {
        private readonly IUserAttendanceService _userAttendanceService;

        public UserAttendanceController(IUserAttendanceService userAttendanceService)
        {
            _userAttendanceService = userAttendanceService;
        }
    }
}
