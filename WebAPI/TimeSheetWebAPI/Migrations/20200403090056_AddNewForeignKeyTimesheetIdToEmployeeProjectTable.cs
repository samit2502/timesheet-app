using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class AddNewForeignKeyTimesheetIdToEmployeeProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_Projects",
                table: "Employee_Projects");

            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });

            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.AddColumn<Guid>(
                name: "TimesheetId",
                table: "Employee_Projects",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_Projects",
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId", "TimesheetId" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Projects_TimesheetId",
                table: "Employee_Projects",
                column: "TimesheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Projects_TimeSheets_TimesheetId",
                table: "Employee_Projects",
                column: "TimesheetId",
                principalTable: "TimeSheets",
                principalColumn: "TimeSheetId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Projects_TimeSheets_TimesheetId",
                table: "Employee_Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_Projects",
                table: "Employee_Projects");

            migrationBuilder.DropIndex(
                name: "IX_Employee_Projects_TimesheetId",
                table: "Employee_Projects");

            migrationBuilder.DropColumn(
                name: "TimesheetId",
                table: "Employee_Projects");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_Projects",
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });
        }
    }
}
