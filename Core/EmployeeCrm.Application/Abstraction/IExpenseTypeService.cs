using EmployeeCrm.Application.DTOs.ExpenseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Abstraction
{
    public interface IExpenseTypeService
    {
        Task<ExpenseCreateDTO> Create(ExpenseCreateDTO expenseCreateDTO);
        Task<ExpenseUpdateDTO> Update(ExpenseUpdateDTO expenseUpdateDTO);
        List<ExpenseDTO> GetExpenses();
        ExpenseDTO GetExpenseById(int id);
    }
}
