using EmployeeCrm.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationListController : ControllerBase
    {
        private readonly IInformationListService _informationListService;

        public InformationListController(IInformationListService informationListService)
        {
            _informationListService = informationListService;
        }
    }
}
