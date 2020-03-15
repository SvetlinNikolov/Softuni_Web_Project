using Microsoft.EntityFrameworkCore.Migrations;

namespace SPN.Forum.Data.Migrations
{
    public partial class RemovedPostImageUrlOnlyUsersAndCategoriesShouldHaveUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
