using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class TimeSheetWebAPIModelsTimeSheetContextSeed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "TimeSheetId", "DayFiveHours", "DayFourHours", "DayOneHours", "DaySevenHours", "DaySixHours", "DayThreeHours", "DayTwoHours", "WeekEndDate", "WeekStartDate" },
                values: new object[] { new Guid("99eed3ad-9ddd-41e1-a234-66bd123456aa"), 8, 8, 8, 0, 0, 8, 8, new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TimeSheets",
                columns: new[] { "TimeSheetId", "DayFiveHours", "DayFourHours", "DayOneHours", "DaySevenHours", "DaySixHours", "DayThreeHours", "DayTwoHours", "WeekEndDate", "WeekStartDate" },
                values: new object[] { new Guid("0f8b0291-a728-43dc-bce7-fb8ad363f339"), 8, 8, 8, 0, 0, 8, 8, new DateTime(2020, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId", "TimesheetId" },
                values: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db"), new Guid("99eed3ad-9ddd-41e1-a234-66bd123456aa") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId", "TimesheetId" },
                values: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"), new Guid("0f8b0291-a728-43dc-bce7-fb8ad363f339") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId", "TimesheetId" },
                keyValues: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"), new Guid("0f8b0291-a728-43dc-bce7-fb8ad363f339") });

            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId", "TimesheetId" },
                keyValues: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db"), new Guid("99eed3ad-9ddd-41e1-a234-66bd123456aa") });

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "TimeSheetId",
                keyValue: new Guid("0f8b0291-a728-43dc-bce7-fb8ad363f339"));

            migrationBuilder.DeleteData(
                table: "TimeSheets",
                keyColumn: "TimeSheetId",
                keyValue: new Guid("99eed3ad-9ddd-41e1-a234-66bd123456aa"));
        }
    }
}
