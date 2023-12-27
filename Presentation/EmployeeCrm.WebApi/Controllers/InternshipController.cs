using EmployeeCrm.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternshipController : ControllerBase
    {
        private readonly IInternshipService _internshipService;

        public InternshipController(IInternshipService internshipService)
        {
            _internshipService = internshipService;
        }
    }
}
