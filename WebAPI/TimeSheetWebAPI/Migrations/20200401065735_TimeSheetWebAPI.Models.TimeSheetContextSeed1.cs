using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class TimeSheetWebAPIModelsTimeSheetContextSeed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "ContactNumber", "DateOfJoining", "Designation", "EmailId", "EmpId", "FirstName", "IsAdmin", "IsManager", "LastName", "Status" },
                values: new object[,]
                {
                    { new Guid("e809d7b6-618a-4b5d-a2b8-9dfeefb29f85"), "1234567891", new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "abc@xyz.com", "SM00000001", "Samitanjaya", false, false, "Mishra", 0 },
                    { new Guid("a9adb739-2b74-4cd1-b3a8-ba1a3ed65cd4"), "1234567092", new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Software Engineer", "abcd@xyza.com", "SM00000002", "Saswati", false, false, "Mohanty", 0 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "PorjectStartDate", "ProId", "ProjectEndDate", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db"), new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OP00000001", new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project-X" },
                    { new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"), new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OP00000002", new DateTime(2030, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project-Y" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("a9adb739-2b74-4cd1-b3a8-ba1a3ed65cd4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e809d7b6-618a-4b5d-a2b8-9dfeefb29f85"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db"));
        }
    }
}
