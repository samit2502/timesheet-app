using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models
{
    public class TimeSheet
    {
        [Key]
        public Guid TimeSheetId { get; set; }
        public DateTime WeekStartDate { get; set; }
        public DateTime WeekEndDate { get; set; }
        [Required]
        public int DayOneHours { get; set; }
        [Required]
        public int DayTwoHours { get; set; }
        [Required]
        public int DayThreeHours { get; set; }
        [Required]
        public int DayFourHours { get; set; }
        [Required]
        public int DayFiveHours { get; set; }
        [Required]
        public int DaySixHours { get; set; }
        [Required]
        public int DaySevenHours { get; set; }
        public ICollection<Employee_Project> Employee_Projects { get; set; }
    }
}
