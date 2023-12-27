using EmployeeCrm.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatisfactionController : ControllerBase
    {
        private readonly ISatisfactionService _satisfactionService;

        public SatisfactionController(ISatisfactionService satisfactionService)
        {
            _satisfactionService = satisfactionService;
        }
    }
}
