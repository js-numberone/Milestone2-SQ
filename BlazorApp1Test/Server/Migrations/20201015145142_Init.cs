using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1Test.Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GForceParameter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    AccelX = table.Column<double>(nullable: false),
                    AccelY = table.Column<double>(nullable: false),
                    AccelZ = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GForceParameter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GForceParameter");
        }
    }
}
