﻿using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.StudentDTOs
{
    public class StudentUpdateDTO
    {
        public int GroupId { get; set; }
        public int LessonId { get; set; }
        public int IntructorId { get; set; }
        public bool Payment { get; set; }
    }
}
