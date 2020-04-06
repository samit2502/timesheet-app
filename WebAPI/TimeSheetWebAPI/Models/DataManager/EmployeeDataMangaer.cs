using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetWebAPI.Models;
using TimeSheetWebAPI.Models.Repository;
using Microsoft.AspNetCore.Identity;

namespace TimeSheetWebAPI.Models.DataManager
{
    public class EmployeeDataMangaer : IDataRepository<Employee>
    {
        readonly TimeSheetContext _employeeContext;
        readonly UserManager<Employee> _userManager;
        private int sEmpCount = 0;

        public EmployeeDataMangaer(TimeSheetContext context, UserManager<Employee> userManager)
        {
            _employeeContext = context;
            _userManager = userManager;
        }

        public IEnumerable<Employee> GetAll()
        {
            //return _employeeContext.Employees.ToList();
            List<Employee> employees = new List<Employee>();
            foreach (var employee in _userManager.Users.ToList())
            {
                employee.Employee_Projects = _employeeContext.Employee_Projects.Where(ep => ep.EmployeeId == employee.Id).ToList();
                employees.Add(employee);
            }
            return employees;
        }

        public string GetUserName(string FirstName, string LastName)
        {
            string userName = "";
            if (FirstName.Length == 0 && LastName.Length == 0)
                return "";
            sEmpCount = sEmpCount + 1;
            userName = Char.ToUpper(FirstName[0]) + "" + Char.ToUpper(LastName[0]) + sEmpCount.ToString().PadLeft(8, '0');

            foreach (var user in _userManager.Users)
            {
                if (userName.Equals(user.UserName))
                {
                    sEmpCount = sEmpCount + 1;
                    userName = Char.ToUpper(FirstName[0]) + "" + Char.ToUpper(LastName[0]) + sEmpCount.ToString().PadLeft(8, '0');
                }
            }
            return userName;
        }
    }
}
