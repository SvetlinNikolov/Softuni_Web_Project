using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class InitialAuto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Contests_ContestId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ContestQuestionAnswers");

            migrationBuilder.DropTable(
                name: "ContestSolutions");

            migrationBuilder.DropTable(
                name: "ContestQuestions");

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

            migrationBuilder.CreateTable(
                name: "Makes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MakesModels",
                columns: table => new
                {
                    MakeId = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakesModels", x => new { x.ModelId, x.MakeId });
                    table.ForeignKey(
                        name: "FK_MakesModels_Makes_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MakesModels_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MakesModels_MakeId",
                table: "MakesModels",
                column: "MakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakesModels");

            migrationBuilder.DropTable(
                name: "Makes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.AddColumn<int>(
                name: "ContestId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContestCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ContestCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionsCount = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false),
                    ContestId = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestQuestions", x => new { x.Id, x.ContestId });
                    table.ForeignKey(
                        name: "FK_ContestQuestions_Contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "Contests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContestSolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ContestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestSolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestSolutions_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContestQuestionContestId = table.Column<int>(type: "int", nullable: false),
                    ContestQuestionId = table.Column<int>(type: "int", nullable: false),
                    ContestQuestionId1 = table.Column<int>(type: "int", nullable: false),
                    ContestSolutionId = table.Column<int>(type: "int", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestQuestionAnswers_ContestSolutions_ContestSolutionId",
                        column: x => x.ContestSolutionId,
                        principalTable: "ContestSolutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContestQuestionAnswers_ContestQuestions_ContestQuestionId1_ContestQuestionContestId",
                        columns: x => new { x.ContestQuestionId1, x.ContestQuestionContestId },
                        principalTable: "ContestQuestions",
                        principalColumns: new[] { "Id", "ContestId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ContestId",
                table: "AspNetUsers",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestionAnswers_ContestSolutionId",
                table: "ContestQuestionAnswers",
                column: "ContestSolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestionAnswers_ContestQuestionId1_ContestQuestionContestId",
                table: "ContestQuestionAnswers",
                columns: new[] { "ContestQuestionId1", "ContestQuestionContestId" });

            migrationBuilder.CreateIndex(
                name: "IX_ContestQuestions_ContestId",
                table: "ContestQuestions",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "IX_Contests_AuthorId",
                table: "Contests",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contests_ContestCategoryId",
                table: "Contests",
                column: "ContestCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestSolutions_AuthorId",
                table: "ContestSolutions",
                column: "AuthorId");

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
    }
}
