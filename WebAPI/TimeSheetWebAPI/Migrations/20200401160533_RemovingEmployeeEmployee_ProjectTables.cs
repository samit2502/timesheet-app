using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class RemovingEmployeeEmployee_ProjectTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Projects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("81f7a3a4-6d95-4db0-9906-fc3798014fc3"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Projects",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Projects", x => new { x.EmployeeId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_Employee_Projects_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Projects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { new Guid("e809d7b6-618a-4b5d-a2b8-9dfeefb29f85"), new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.InsertData(
                table: "Employee_Projects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[] { new Guid("a9adb739-2b74-4cd1-b3a8-ba1a3ed65cd4"), new Guid("99eed6eb-8cdc-40e0-a212-45bd018115db") });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Projects_ProjectId",
                table: "Employee_Projects",
                column: "ProjectId");
        }
    }
}
