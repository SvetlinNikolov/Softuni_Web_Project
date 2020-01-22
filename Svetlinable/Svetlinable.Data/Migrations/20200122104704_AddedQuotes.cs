using Microsoft.EntityFrameworkCore.Migrations;

namespace Svetlinable.Data.Migrations
{
    public partial class AddedQuotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "ReplyLikes");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "PostLikes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Value",
                table: "ReplyLikes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Value",
                table: "PostLikes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
