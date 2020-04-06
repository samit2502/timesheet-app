using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TimeSheetWebAPI.Models.RoleModel;
using TimeSheetWebAPI.Models;

namespace TimeSheetWebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> rolemanager;
        private readonly UserManager<Employee> userManager;
        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<Employee> userManager)
        {
            this.rolemanager = roleManager;
            this.userManager = userManager;
        }

        [Route("createRole")]
        [HttpPost]
        public async Task<IActionResult> CreateRoles(CreateRoleModel role)
        {
            try
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = role.RoleName
                };

                IdentityResult result = await rolemanager.CreateAsync(identityRole);
                return Ok(identityRole.Name + " has been created");
            }
            catch(Exception ex)
            {
                return BadRequest("Please Enter a valid role name");
            }
        }

        [Route("addUserToRole")]
        [HttpPost]
        public async Task<IActionResult> AddUsersToRoles(AddUserToRoleModel model)
        {
            try
            {
                var role = await rolemanager.FindByIdAsync(model.RoleId);
                var employee = await userManager.FindByIdAsync(model.EmployeeId);
                IdentityResult result = null;

                if (!(await userManager.IsInRoleAsync(employee, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(employee, role.Name);
                }
                if (result.Succeeded)
                {

                    return Ok(employee.FullName + " is added to the role of " + role.Name);
                }
                else
                {
                    return Ok(employee.FullName + " has already been added to the role " + role.Name);
                }
            }
            catch(Exception ex)
            {
                return BadRequest("Could not add Employee to the Role");
            }
        }
    }
}