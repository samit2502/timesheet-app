using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models
{
    public class Employee: IdentityUser
    {
        public enum StatusInd
        {
            Active,
            Inactive,
            Sabbatical,
            YetToJoin,
        }
        [Column(TypeName ="nvarchar(256)")]
        [Required]
        public string Designation { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
        public bool IsManager { get; set; }
        public bool IsAdmin { get; set; }
        [Required]
        public StatusInd Status { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Address { get; set; }
        public ICollection<Employee_Project> Employee_Projects { get; set; }
    }
}
