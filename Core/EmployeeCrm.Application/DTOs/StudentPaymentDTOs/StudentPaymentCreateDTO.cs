﻿using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.StudentPaymentDTOs
{
    public class StudentPaymentCreateDTO
    {
        public int LessonId { get; set; }
        public decimal Amount { get; set; }
    }
}
