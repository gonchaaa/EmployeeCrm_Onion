using EmployeeCrm.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseTypeController : ControllerBase
    {
        private readonly IExpenseTypeService _expenseTypeService;

        public ExpenseTypeController(IExpenseTypeService expenseTypeService)
        {
            _expenseTypeService = expenseTypeService;
        }
    }
}
