using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Forum.Data.Migrations
{
    public partial class Removed_Foreign_Key_In_Contest_Question : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestQuestions_Contests_Id",
                table: "ContestQuestions");

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestions_ContestId",
                table: "ContestQuestions",
                column: "ContestId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestQuestions_Contests_ContestId",
                table: "ContestQuestions",
                column: "ContestId",
                principalTable: "Contests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestQuestions_Contests_ContestId",
                table: "ContestQuestions");

            migrationBuilder.DropIndex(
                name: "IX_ContestQuestions_ContestId",
                table: "ContestQuestions");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestQuestions_Contests_Id",
                table: "ContestQuestions",
                column: "Id",
                principalTable: "Contests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
