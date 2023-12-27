using EmployeeCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities;
public class Expense : BaseEntity
{
    public decimal Price { get; set; }
    public string? Note { get; set; }
    public decimal Quantity { get; set; }
    public ExpenseType ExpenseType { get; set; }
}