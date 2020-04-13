using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class Add_ExtraFeatures_To_Automobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Mileage",
                table: "PrimaryProperties",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Region",
                table: "PrimaryProperties",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExtraFeaturesId",
                table: "Automobiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ExtraFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    KeylessEntry = table.Column<bool>(nullable: true),
                    KeylessIgnition = table.Column<bool>(nullable: true),
                    LowGear = table.Column<bool>(nullable: true),
                    PanoramicRoof = table.Column<bool>(nullable: true),
                    RoofRack = table.Column<bool>(nullable: true),
                    ElectricTailgate = table.Column<bool>(nullable: true),
                    LongBase = table.Column<bool>(nullable: true),
                    ShortBase = table.Column<bool>(nullable: true),
                    Registered = table.Column<bool>(nullable: true),
                    MOT = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraFeatures", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automobiles_ExtraFeaturesId",
                table: "Automobiles",
                column: "ExtraFeaturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_ExtraFeatures_ExtraFeaturesId",
                table: "Automobiles",
                column: "ExtraFeaturesId",
                principalTable: "ExtraFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_ExtraFeatures_ExtraFeaturesId",
                table: "Automobiles");

            migrationBuilder.DropTable(
                name: "ExtraFeatures");

            migrationBuilder.DropIndex(
                name: "IX_Automobiles_ExtraFeaturesId",
                table: "Automobiles");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "PrimaryProperties");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "PrimaryProperties");

            migrationBuilder.DropColumn(
                name: "ExtraFeaturesId",
                table: "Automobiles");
        }
    }
}
