using System;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TimeSheetWebAPI.Models
{
    public class TimeSheetContext: IdentityDbContext
    {
        public TimeSheetContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*base.OnModelCreating(modelBuilder) is Added to map the keys properly so that we dont get,
            The entity type 'IdentityUserLogin<string>' requires a primary key to be defined. 
            If you intended to use a keyless entity type call 'HasNoKey()'. */

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.Parse("e809d7b6-618a-4b5d-a2b8-9dfeefb29f85"),
                FirstName = "Samitanjaya",
                LastName = "Mishra",
                EmpId = "SM00000001",
                EmailId = "abc@xyz.com",
                ContactNumber = "1234567891",
                Designation = "Software Engineer",
                DateOfJoining = new System.DateTime(2019, 08, 05),
                IsManager = false,
                IsAdmin = false,
                Status = Employee.StatusInd.Active

            }, new Employee
            {
                EmployeeId = Guid.Parse("a9adb739-2b74-4cd1-b3a8-ba1a3ed65cd4"),
                FirstName = "Saswati",
                LastName = "Mohanty",
                EmpId = "SM00000002",
                EmailId = "abcd@xyza.com",
                ContactNumber = "1234567092",
                Designation = "Senior Software Engineer",
                DateOfJoining = new System.DateTime(2016, 01, 05),
                IsManager = false,
                IsAdmin = false,
                Status = Employee.StatusInd.Active
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = Guid.Parse("99eed6eb-8cdc-40e0-a212-45bd018115db"),
                ProId = "OP00000001",
                ProjectName = "Project-X",
                PorjectStartDate = new System.DateTime(2016, 01, 01),
                ProjectEndDate = new System.DateTime(2030, 01, 01)

            }, new Project
            {
                ProjectId = Guid.Parse("81f7a3a4-6d95-4db0-9906-fc3798014fc3"),
                ProId = "OP00000002",
                ProjectName = "Project-Y",
                PorjectStartDate = new System.DateTime(2016, 02, 01),
                ProjectEndDate = new System.DateTime(2030, 02, 01)
            });

            modelBuilder.Entity<Employee_Project>().HasData(new Employee_Project
            {
                EmployeeId = new Guid("e809d7b6-618a-4b5d-a2b8-9dfeefb29f85"),
                ProjectId = new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db")

            }, new Employee_Project
            {
                EmployeeId = new Guid("a9adb739-2b74-4cd1-b3a8-ba1a3ed65cd4"),
                ProjectId = new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db")
            });
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee_Project> Employee_Projects { get; set; }
    }
}
