using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeSheetWebAPI.Models
{
    public class EmployeeProjectConfiguration: IEntityTypeConfiguration<Employee_Project>
    {
        public void Configure(EntityTypeBuilder<Employee_Project> builder)
        {
            builder.HasKey(ep => new { ep.EmployeeId, ep.ProjectId, ep.TimesheetId });
            
            //builder.HasOne<Employee>(ep => ep.Employee)
            //    .WithMany(e => e.Employee_Projects)
            //    .HasForeignKey(ep => ep.Id);

            //builder.HasOne<Project>(ep => ep.Project)
            //    .WithMany(e => e.Employee_Projects)
            //    .HasForeignKey(ep => ep.ProjectId);
        }
    }
}
