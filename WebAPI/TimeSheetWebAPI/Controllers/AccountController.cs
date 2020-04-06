using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using TimeSheetWebAPI.Models;
using TimeSheetWebAPI.Utility;
using TimeSheetWebAPI.Models.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace TimeSheetWebAPI.Controllers
{
    [ApiController]
    [Route("")]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<Employee> _userManager;
        private readonly SignInManager<Employee> _signInManager;
        private readonly IDataRepository<Employee> _dataRepository;
        //private static int sEmpCount = 0;

        public AccountController(UserManager<Employee> userManager, SignInManager<Employee> signInManager, IDataRepository<Employee> dataRepository, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dataRepository = dataRepository;
            _configuration = configuration;
        }

        [Route("Register")]
        //[Authorize]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserRegistrationModel userRegistrationModel)
        {
            try
            {
                var user = new Employee
                {
                    UserName = _dataRepository.GetUserName(userRegistrationModel.FirstName, userRegistrationModel.LastName),
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
        public async Task<IActionResult> Login(Login loginModel)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password, false, false);
                if (result.Succeeded == true)
                {
                    var employee = _userManager.Users.SingleOrDefault(emp => emp.UserName == loginModel.UserName);
                    return Ok(GenerateJwtToken(loginModel.UserName, employee));
                }
                else
                {
                    return BadRequest("Invalid Login Attempt");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Sign in failed" + ex);
            }
        }

        private Object GenerateJwtToken(string userName, Employee employee)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, employee.Id),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}