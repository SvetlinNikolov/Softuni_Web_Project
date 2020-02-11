using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class InitialQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContestId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContestCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ContestCategoryId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    QuestionsCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contests_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contests_ContestCategories_ContestCategoryId",
                        column: x => x.ContestCategoryId,
                        principalTable: "ContestCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContestQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ContestId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    QuestionType = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestQuestions_Contests_Id",
                        column: x => x.Id,
                        principalTable: "Contests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContestSolutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContestId = table.Column<int>(nullable: false),
                    AuthorId1 = table.Column<string>(nullable: true),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestSolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestSolutions_AspNetUsers_AuthorId1",
                        column: x => x.AuthorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContestSolutions_Contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "Contests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContestQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContestQuestionId = table.Column<int>(nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    ContestSolutionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestQuestionAnswers_ContestQuestions_ContestQuestionId",
                        column: x => x.ContestQuestionId,
                        principalTable: "ContestQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContestQuestionAnswers_ContestSolutions_ContestSolutionId",
                        column: x => x.ContestSolutionId,
                        principalTable: "ContestSolutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ContestId",
                table: "AspNetUsers",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestionAnswers_ContestQuestionId",
                table: "ContestQuestionAnswers",
                column: "ContestQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestionAnswers_ContestSolutionId",
                table: "ContestQuestionAnswers",
                column: "ContestSolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contests_AuthorId",
                table: "Contests",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contests_ContestCategoryId",
                table: "Contests",
                column: "ContestCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestSolutions_AuthorId1",
                table: "ContestSolutions",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContestSolutions_ContestId",
                table: "ContestSolutions",
                column: "ContestId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Contests_ContestId",
                table: "AspNetUsers",
                column: "ContestId",
                principalTable: "Contests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Contests_ContestId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ContestQuestionAnswers");

            migrationBuilder.DropTable(
                name: "ContestQuestions");

            migrationBuilder.DropTable(
                name: "ContestSolutions");

            migrationBuilder.DropTable(
                name: "Contests");

            migrationBuilder.DropTable(
                name: "ContestCategories");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ContestId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ContestId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");
        }
    }
}
