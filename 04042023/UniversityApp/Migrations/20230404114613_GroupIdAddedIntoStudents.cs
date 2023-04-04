using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Migrations
{
    public partial class GroupIdAddedIntoStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupNo",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "GroupNo",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
