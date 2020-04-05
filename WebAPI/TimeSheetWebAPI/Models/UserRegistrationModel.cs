using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models
{
    public class UserRegistrationModel
    {
        public enum StatusInd
        {
            Active,
            Inactive,
            Sabbatical,
            YetToJoin,
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfJoining { get; set; }
        public bool IsManager { get; set; }
        public bool IsAdmin { get; set; }
        public StatusInd Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
