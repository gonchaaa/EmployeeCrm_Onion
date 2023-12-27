using EmployeeCrm.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterBlankController : ControllerBase
    {
        private readonly IRegisterBlankService _registerBlankService;

        public RegisterBlankController(IRegisterBlankService registerBlankService)
        {
            _registerBlankService = registerBlankService;
        }
    }
}
