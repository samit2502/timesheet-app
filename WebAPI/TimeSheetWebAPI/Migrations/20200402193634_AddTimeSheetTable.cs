using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetWebAPI.Migrations
{
    public partial class AddTimeSheetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSheets",
                columns: table => new
                {
                    TimeSheetId = table.Column<Guid>(nullable: false),
                    ProjectId = table.Column<string>(nullable: false),
                    WeekStartDate = table.Column<DateTime>(nullable: false),
                    WeekEndDate = table.Column<DateTime>(nullable: false),
                    DayOneHours = table.Column<int>(nullable: false),
                    DayTwoHours = table.Column<int>(nullable: false),
                    DayThreeHours = table.Column<int>(nullable: false),
                    DayFourHours = table.Column<int>(nullable: false),
                    DayFiveHours = table.Column<int>(nullable: false),
                    DaySixHours = table.Column<int>(nullable: false),
                    DaySevenHours = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheets", x => x.TimeSheetId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSheets");
        }
    }
}
