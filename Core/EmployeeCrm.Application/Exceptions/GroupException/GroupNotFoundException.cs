﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.Exceptions.GroupException
{
    public class GroupNotFoundException : Exception
    {
        public GroupNotFoundException() : base("Event not found")
        {
        }

        public GroupNotFoundException(string? message) : base(message)
        {
        }

        public GroupNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}
