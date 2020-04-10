using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class AddAutomobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automobiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    MakeId1 = table.Column<int>(nullable: true),
                    MakeId = table.Column<string>(nullable: true),
                    ModelId1 = table.Column<int>(nullable: true),
                    ModelId = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Year = table.Column<DateTime>(nullable: false),
                    Horsepower = table.Column<int>(nullable: false),
                    Engine = table.Column<int>(nullable: false),
                    GearBox = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Automobiles_Makes_MakeId1",
                        column: x => x.MakeId1,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Automobiles_Models_ModelId1",
                        column: x => x.ModelId1,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_MakeId1",
                table: "Automobiles",
                column: "MakeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_ModelId1",
                table: "Automobiles",
                column: "ModelId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automobiles");
        }
    }
}
