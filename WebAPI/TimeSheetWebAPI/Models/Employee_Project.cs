using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models
{
    public class Employee_Project
    {
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
