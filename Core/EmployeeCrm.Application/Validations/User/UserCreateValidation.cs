﻿using EmployeeCrm.Application.DTOs.SatisfactionsDTOs;
using EmployeeCrm.Application.DTOs.UserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.User
{
    public class UserCreateValidation : AbstractValidator<UserCreateDTO>
    {
    }
}