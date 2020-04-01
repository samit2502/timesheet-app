using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetWebAPI.Models;
using TimeSheetWebAPI.Models.Repository;

namespace TimeSheetWebAPI.Models.DataManager
{
    //public class EmployeeDataMangaer : IDataRepository<Employee>
    //{
    //    readonly TimeSheetContext _employeeContext;

    //    public EmployeeDataMangaer(TimeSheetContext context)
    //    {
    //        _employeeContext = context;
    //    }

    //    public IEnumerable<Employee> GetAll()
    //    {
    //        return _employeeContext.Employees.ToList();
    //        List<Employee> employees = new List<Employee>();
    //        foreach (var employee in _employeeContext.Employees.ToList())
    //        {
    //            employee.Employee_Projects = _employeeContext.Employee_Projects.Where(ep => ep.EmployeeId == employee.EmployeeId).ToList();
    //            employees.Add(employee);
    //        }
    //        return employees;
    //    }
    //}
}
