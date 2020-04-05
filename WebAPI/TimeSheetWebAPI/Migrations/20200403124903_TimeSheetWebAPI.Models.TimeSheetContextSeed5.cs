using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class TimeSheetWebAPIModelsTimeSheetContextSeed5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId", "TimesheetId" },
                values: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"), new Guid("99eed3ad-9ddd-41e1-a234-66bd123456aa") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId", "TimesheetId" },
                keyValues: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"), new Guid("99eed3ad-9ddd-41e1-a234-66bd123456aa") });
        }
    }
}
