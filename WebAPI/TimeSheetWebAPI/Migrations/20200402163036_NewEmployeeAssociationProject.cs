using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class NewEmployeeAssociationProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });

            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });

            migrationBuilder.DeleteData(
                table: "Employee_Projects",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { "e183d367-424b-4957-9cdf-8c9031b708bd", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { "e984e550-3ab1-44fe-ad3d-75504f8ead3a", new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3") });
        }
    }
}
