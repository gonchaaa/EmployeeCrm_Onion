using EmployeeCrm.Application.DTOs.EmployeeDTOs;
using EmployeeCrm.Application.DTOs.EventDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Validations.Event
{
    public class EventCreateValidation : AbstractValidator<CreateEventDTO>
    {
        public EventCreateValidation()
        {
            RuleFor(x => x.Title).NotEmpty().MinimumLength(3).WithMessage("Yorduz meni.").MaximumLength(6).WithMessage("Ucden asagi yaz.");
        }
    }
}
