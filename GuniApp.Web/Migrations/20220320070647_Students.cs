using Microsoft.EntityFrameworkCore.Migrations;

namespace GuniApp.Web.Migrations
{
    public partial class Students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupDetails",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "FacultyName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyName",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "GroupDetails",
                table: "Students",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
