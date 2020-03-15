using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Forum.Data.Migrations
{
    public partial class ContestSolutionAuthorIdStringFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestSolutions_AspNetUsers_AuthorId1",
                table: "ContestSolutions");

            migrationBuilder.DropIndex(
                name: "IX_ContestSolutions_AuthorId1",
                table: "ContestSolutions");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "ContestSolutions");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "ContestSolutions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ContestSolutions_AuthorId",
                table: "ContestSolutions",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestSolutions_AspNetUsers_AuthorId",
                table: "ContestSolutions",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestSolutions_AspNetUsers_AuthorId",
                table: "ContestSolutions");

            migrationBuilder.DropIndex(
                name: "IX_ContestSolutions_AuthorId",
                table: "ContestSolutions");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "ContestSolutions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "ContestSolutions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContestSolutions_AuthorId1",
                table: "ContestSolutions",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestSolutions_AspNetUsers_AuthorId1",
                table: "ContestSolutions",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
