using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models
{
    public class Employee
    {
        public enum StatusInd
        {
            Active,
            Inactive,
            Sabbatical,
            YetToJoin,
        }
        [Key]
        public Guid EmployeeId { get; set; }
        [Required]
        public string EmpId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
        public bool IsManager { get; set; }
        public bool IsAdmin { get; set; }
        [Required]
        public StatusInd Status { get; set; }
        public ICollection<Employee_Project> Employee_Projects { get; set; }
    }
}
