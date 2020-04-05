using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimeSheetWebAPI.Models;
using TimeSheetWebAPI.Models.Repository;

namespace TimeSheetWebAPI.Controllers
{
    //[Route("")]
    [Route("Employee")]
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _dataRepository;
        public EmployeeController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();

            if (employees == null)
                return NotFound();

            return Ok(employees);
        }
    }
}