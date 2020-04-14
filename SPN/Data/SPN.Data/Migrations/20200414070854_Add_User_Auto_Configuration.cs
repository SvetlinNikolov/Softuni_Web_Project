using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class Add_User_Auto_Configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_AspNetUsers_UserId1",
                table: "Automobiles");

            migrationBuilder.DropIndex(
                name: "IX_Automobiles_UserId1",
                table: "Automobiles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Automobiles");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_UserId",
                table: "Automobiles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_AspNetUsers_UserId",
                table: "Automobiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_AspNetUsers_UserId",
                table: "Automobiles");

            migrationBuilder.DropIndex(
                name: "IX_Automobiles_UserId",
                table: "Automobiles");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Automobiles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_UserId1",
                table: "Automobiles",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_AspNetUsers_UserId1",
                table: "Automobiles",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
