using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Migrations
{
    public partial class GroupNoAddedIntoStudnets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupNo",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupNo",
                table: "Students");
        }
    }
}
