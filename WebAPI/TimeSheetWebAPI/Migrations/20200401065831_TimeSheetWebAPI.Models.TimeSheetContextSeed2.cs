using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class TimeSheetWebAPIModelsTimeSheetContextSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { new Guid("e809d7b6-618a-4b5d-a2b8-9dfeefb29f85"), new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { new Guid("a9adb739-2b74-4cd1-b3a8-ba1a3ed65cd4"), new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("a9adb739-2b74-4cd1-b3a8-ba1a3ed65cd4"), new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("e809d7b6-618a-4b5d-a2b8-9dfeefb29f85"), new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });
        }
    }
}
