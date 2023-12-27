using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Domain.Entities
{
    public class EmployeerLesson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double? Salary { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime Present { get; set; }
    }
}
