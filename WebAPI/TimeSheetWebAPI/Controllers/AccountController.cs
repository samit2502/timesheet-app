using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using TimeSheetWebAPI.Models;

namespace TimeSheetWebAPI.Controllers
{
    [Route("")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<Employee> _userManager;
        private SignInManager<Employee> _signInManager;
        private static int sEmpCount = 0;

        public AccountController(UserManager<Employee> userManager, SignInManager<Employee> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationModel userRegistrationModel)
        {
            try
            {
                var user = new Employee
                {
                    UserName = GetUserName(userRegistrationModel.FirstName, userRegistrationModel.LastName),
                    Email = userRegistrationModel.Email,
                    Designation = userRegistrationModel.Designation,
                    DateOfJoining = userRegistrationModel.DateOfJoining,
                    IsManager = userRegistrationModel.IsManager,
                    IsAdmin = userRegistrationModel.IsAdmin,
                    Status = (Employee.StatusInd)userRegistrationModel.Status,
                    FullName = userRegistrationModel.FirstName + " " + userRegistrationModel.LastName,
                    Address = userRegistrationModel.Address
                };

                var result = await _userManager.CreateAsync(user, userRegistrationModel.Password);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] Login loginModel)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, false, false);
                return Ok("Sign In Successful");
            }
            catch(Exception ex)
            {
                return BadRequest("Sign in failed" + ex);
            }
        }

        static string GetUserName(string FirstName, string LastName)
        {
            if (FirstName.Length == 0 && LastName.Length == 0)
                return "";
            sEmpCount = sEmpCount + 1;
            return Char.ToUpper(FirstName[0]) + "" + Char.ToUpper(LastName[0]) + sEmpCount.ToString().PadLeft(8, '0');
        }
    }
}