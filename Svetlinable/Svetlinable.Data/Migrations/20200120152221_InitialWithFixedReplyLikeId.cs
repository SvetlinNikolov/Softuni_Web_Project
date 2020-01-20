using Microsoft.EntityFrameworkCore.Migrations;

namespace Svetlinable.Data.Migrations
{
    public partial class InitialWithFixedReplyLikeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyLikes_AspNetUsers_UserId1",
                table: "ReplyLikes");

            migrationBuilder.DropIndex(
                name: "IX_ReplyLikes_UserId1",
                table: "ReplyLikes");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "ReplyLikes");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ReplyLikes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyLikes_UserId",
                table: "ReplyLikes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyLikes_AspNetUsers_UserId",
                table: "ReplyLikes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyLikes_AspNetUsers_UserId",
                table: "ReplyLikes");

            migrationBuilder.DropIndex(
                name: "IX_ReplyLikes_UserId",
                table: "ReplyLikes");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ReplyLikes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "ReplyLikes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReplyLikes_UserId1",
                table: "ReplyLikes",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyLikes_AspNetUsers_UserId1",
                table: "ReplyLikes",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
