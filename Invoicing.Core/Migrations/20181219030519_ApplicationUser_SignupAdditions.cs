using Microsoft.EntityFrameworkCore.Migrations;

namespace Invoicing.Core.Migrations
{
    public partial class ApplicationUser_SignupAdditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "ApplicationUsers",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "ApplicationUsers",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ApplicationUsers",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ApplicationUsers",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ApplicationUsers");
        }
    }
}
