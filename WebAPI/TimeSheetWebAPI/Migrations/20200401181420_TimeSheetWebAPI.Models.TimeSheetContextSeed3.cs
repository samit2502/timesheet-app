using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class TimeSheetWebAPIModelsTimeSheetContextSeed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "PorjectStartDate", "ProId", "ProjectEndDate", "ProjectName" },
                values: new object[] { new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db"), new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OP00000001", new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project-X" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "PorjectStartDate", "ProId", "ProjectEndDate", "ProjectName" },
                values: new object[] { new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"), new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OP00000002", new DateTime(2030, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project-Y" });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });

            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

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
