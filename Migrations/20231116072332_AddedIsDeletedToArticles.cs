using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorBlog.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsDeletedToArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Articles");
        }
    }
}
