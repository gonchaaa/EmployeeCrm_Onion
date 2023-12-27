using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.DTOs.EventDTOs
{
    public class EventUpdateDTO
    {
        public string Title { get; set; }
        public DateTime EventTime { get; set; }
        public string Location { get; set; }
        public string Organizator { get; set; }
    }
}
