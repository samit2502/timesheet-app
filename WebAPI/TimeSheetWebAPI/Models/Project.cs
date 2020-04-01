using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }
        [Required]
        public string ProId { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public DateTime PorjectStartDate { get; set; }
        [Required]
        public DateTime ProjectEndDate { get; set; }
        public ICollection<Employee_Project> Employee_Projects { get; set; }
    }
}
