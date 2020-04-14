using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class Update_Automobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mileage",
                table: "PrimaryProperties",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Automobiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Automobiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Automobiles");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Automobiles");

            migrationBuilder.AlterColumn<int>(
                name: "Mileage",
                table: "PrimaryProperties",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
