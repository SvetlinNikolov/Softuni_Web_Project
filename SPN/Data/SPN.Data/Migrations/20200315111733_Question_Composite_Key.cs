using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Forum.Data.Migrations
{
    public partial class Question_Composite_Key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestQuestionAnswers_ContestQuestions_ContestQuestionId",
                table: "ContestQuestionAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContestQuestions",
                table: "ContestQuestions");

            migrationBuilder.DropIndex(
                name: "IX_ContestQuestionAnswers_ContestQuestionId",
                table: "ContestQuestionAnswers");

            migrationBuilder.AddColumn<int>(
                name: "ContestQuestionContestId",
                table: "ContestQuestionAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContestQuestionId1",
                table: "ContestQuestionAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContestQuestions",
                table: "ContestQuestions",
                columns: new[] { "Id", "ContestId" });

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestionAnswers_ContestQuestionId1_ContestQuestionContestId",
                table: "ContestQuestionAnswers",
                columns: new[] { "ContestQuestionId1", "ContestQuestionContestId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ContestQuestionAnswers_ContestQuestions_ContestQuestionId1_ContestQuestionContestId",
                table: "ContestQuestionAnswers",
                columns: new[] { "ContestQuestionId1", "ContestQuestionContestId" },
                principalTable: "ContestQuestions",
                principalColumns: new[] { "Id", "ContestId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestQuestionAnswers_ContestQuestions_ContestQuestionId1_ContestQuestionContestId",
                table: "ContestQuestionAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContestQuestions",
                table: "ContestQuestions");

            migrationBuilder.DropIndex(
                name: "IX_ContestQuestionAnswers_ContestQuestionId1_ContestQuestionContestId",
                table: "ContestQuestionAnswers");

            migrationBuilder.DropColumn(
                name: "ContestQuestionContestId",
                table: "ContestQuestionAnswers");

            migrationBuilder.DropColumn(
                name: "ContestQuestionId1",
                table: "ContestQuestionAnswers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContestQuestions",
                table: "ContestQuestions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestionAnswers_ContestQuestionId",
                table: "ContestQuestionAnswers",
                column: "ContestQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestQuestionAnswers_ContestQuestions_ContestQuestionId",
                table: "ContestQuestionAnswers",
                column: "ContestQuestionId",
                principalTable: "ContestQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
