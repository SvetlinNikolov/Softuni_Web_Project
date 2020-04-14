using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class Added_Images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImagesId",
                table: "Automobiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    ImageUrl1 = table.Column<string>(nullable: true),
                    ImageUrl2 = table.Column<string>(nullable: true),
                    ImageUrl3 = table.Column<string>(nullable: true),
                    ImageUrl4 = table.Column<string>(nullable: true),
                    ImageUrl5 = table.Column<string>(nullable: true),
                    ImageUrl6 = table.Column<string>(nullable: true),
                    ImageUrl7 = table.Column<string>(nullable: true),
                    ImageUrl8 = table.Column<string>(nullable: true),
                    ImageUrl9 = table.Column<string>(nullable: true),
                    ImageUrl10 = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_ImagesId",
                table: "Automobiles",
                column: "ImagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Images_ImagesId",
                table: "Automobiles",
                column: "ImagesId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Images_ImagesId",
                table: "Automobiles");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Automobiles_ImagesId",
                table: "Automobiles");

            migrationBuilder.DropColumn(
                name: "ImagesId",
                table: "Automobiles");
        }
    }
}
