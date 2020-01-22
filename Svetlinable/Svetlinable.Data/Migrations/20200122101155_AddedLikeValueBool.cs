using Microsoft.EntityFrameworkCore.Migrations;

namespace Svetlinable.Data.Migrations
{
    public partial class AddedLikeValueBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Value",
                table: "ReplyLikes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Value",
                table: "PostLikes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "ReplyLikes");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "PostLikes");
        }
    }
}
