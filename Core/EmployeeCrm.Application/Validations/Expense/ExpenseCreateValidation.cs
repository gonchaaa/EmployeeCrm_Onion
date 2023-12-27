﻿using EmployeeCrm.Application.DTOs.EmployeeDTOs;
using EmployeeCrm.Application.DTOs.ExpenseDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.Expense
{
    public class ExpenseCreateValidation : AbstractValidator<ExpenseCreateDTO>
    {
    }
}
