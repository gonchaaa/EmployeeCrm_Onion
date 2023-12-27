using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.ExpenseDTOs
{
    public class ExpenseCreateDTO
    {
        public decimal Price { get; set; }
        public string? Note { get; set; }
        public decimal Quantity { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
