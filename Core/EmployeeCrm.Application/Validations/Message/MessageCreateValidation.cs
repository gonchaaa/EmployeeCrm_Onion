using EmployeeCrm.Application.DTOs.EmployeeDTOs;
using EmployeeCrm.Application.DTOs.MessageDTOs;
using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.Message
{
    public class MessageCreateValidation : AbstractValidator<MessageCreateDTO>
    {
    }
}
