using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTrack.Migrations
{
    public partial class TryAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeEntry",
                columns: table => new
                {
                    TimeEntryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<float>(nullable: false),
                    WorkDate = table.Column<DateTime>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeEntry", x => x.TimeEntryId);
                    table.ForeignKey(
                        name: "FK_TimeEntry_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntry_ProjectId",
                table: "TimeEntry",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeEntry");
        }
    }
}
