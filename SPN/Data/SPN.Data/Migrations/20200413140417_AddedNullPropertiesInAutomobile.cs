using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Data.Migrations
{
    public partial class AddedNullPropertiesInAutomobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_ExtraFeatures_ExtraFeaturesId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_InteriorMaterials_InteriorMaterialsId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Interiors_InteriorsId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Makes_MakeId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Models_ModelId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_PrimaryProperties_PrimaryPropertiesId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_SafetyFeatures_SafetyId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_SpecializedFeatures_SpecializedFeaturesId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Suspensions_SuspensionsId",
                table: "Automobiles");

            migrationBuilder.AlterColumn<int>(
                name: "SuspensionsId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SpecializedFeaturesId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SafetyId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PrimaryPropertiesId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InteriorsId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InteriorMaterialsId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExtraFeaturesId",
                table: "Automobiles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_ExtraFeatures_ExtraFeaturesId",
                table: "Automobiles",
                column: "ExtraFeaturesId",
                principalTable: "ExtraFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_InteriorMaterials_InteriorMaterialsId",
                table: "Automobiles",
                column: "InteriorMaterialsId",
                principalTable: "InteriorMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Interiors_InteriorsId",
                table: "Automobiles",
                column: "InteriorsId",
                principalTable: "Interiors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Makes_MakeId",
                table: "Automobiles",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Models_ModelId",
                table: "Automobiles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_PrimaryProperties_PrimaryPropertiesId",
                table: "Automobiles",
                column: "PrimaryPropertiesId",
                principalTable: "PrimaryProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_SafetyFeatures_SafetyId",
                table: "Automobiles",
                column: "SafetyId",
                principalTable: "SafetyFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_SpecializedFeatures_SpecializedFeaturesId",
                table: "Automobiles",
                column: "SpecializedFeaturesId",
                principalTable: "SpecializedFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Suspensions_SuspensionsId",
                table: "Automobiles",
                column: "SuspensionsId",
                principalTable: "Suspensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_ExtraFeatures_ExtraFeaturesId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_InteriorMaterials_InteriorMaterialsId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Interiors_InteriorsId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Makes_MakeId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Models_ModelId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_PrimaryProperties_PrimaryPropertiesId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_SafetyFeatures_SafetyId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_SpecializedFeatures_SpecializedFeaturesId",
                table: "Automobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Automobiles_Suspensions_SuspensionsId",
                table: "Automobiles");

            migrationBuilder.AlterColumn<int>(
                name: "SuspensionsId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpecializedFeaturesId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SafetyId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrimaryPropertiesId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InteriorsId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InteriorMaterialsId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExtraFeaturesId",
                table: "Automobiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_ExtraFeatures_ExtraFeaturesId",
                table: "Automobiles",
                column: "ExtraFeaturesId",
                principalTable: "ExtraFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_InteriorMaterials_InteriorMaterialsId",
                table: "Automobiles",
                column: "InteriorMaterialsId",
                principalTable: "InteriorMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Interiors_InteriorsId",
                table: "Automobiles",
                column: "InteriorsId",
                principalTable: "Interiors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Makes_MakeId",
                table: "Automobiles",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Models_ModelId",
                table: "Automobiles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_PrimaryProperties_PrimaryPropertiesId",
                table: "Automobiles",
                column: "PrimaryPropertiesId",
                principalTable: "PrimaryProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_SafetyFeatures_SafetyId",
                table: "Automobiles",
                column: "SafetyId",
                principalTable: "SafetyFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_SpecializedFeatures_SpecializedFeaturesId",
                table: "Automobiles",
                column: "SpecializedFeaturesId",
                principalTable: "SpecializedFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automobiles_Suspensions_SuspensionsId",
                table: "Automobiles",
                column: "SuspensionsId",
                principalTable: "Suspensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
