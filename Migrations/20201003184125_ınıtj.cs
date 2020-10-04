using Microsoft.EntityFrameworkCore.Migrations;

namespace CommentApp.Migrations
{
    public partial class ınıtj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentCnt",
                table: "posts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentCnt",
                table: "posts");
        }
    }
}
