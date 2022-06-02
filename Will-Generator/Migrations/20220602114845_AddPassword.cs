using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Will_Generator.Migrations
{
    public partial class AddPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PersonalDetails");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "PersonalDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "PersonalDetails");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PersonalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
