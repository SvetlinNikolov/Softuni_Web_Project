using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Forum.Data.Migrations
{
    public partial class Quote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ReplyLikes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ReplyLikes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ReplyLikes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ReplyLikes");
        }
    }
}
