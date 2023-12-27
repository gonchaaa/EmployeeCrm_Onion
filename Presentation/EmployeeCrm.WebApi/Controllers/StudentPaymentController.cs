using EmployeeCrm.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPaymentController : ControllerBase
    {
        private readonly IStudentPaymentService _studentPaymentService;

        public StudentPaymentController(IStudentPaymentService studentPaymentService)
        {
            _studentPaymentService = studentPaymentService;
        }
    }
}
