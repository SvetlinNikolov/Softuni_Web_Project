using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Forum.Data.Migrations
{
    public partial class AddedConsolePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Contests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Contests");
        }
    }
}
