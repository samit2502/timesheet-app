﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetWebAPI.Models.RoleModel
{
    public class AddUserToRoleModel
    {
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string RoleId { get; set; }
    }
}
