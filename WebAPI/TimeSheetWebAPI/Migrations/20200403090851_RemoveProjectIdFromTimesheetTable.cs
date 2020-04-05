using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class RemoveProjectIdFromTimesheetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "TimeSheets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "TimeSheets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
