using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcFrontToBack.Migrations
{
    /// <inheritdoc />
    public partial class IsMainColumnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "ProjectImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "ProjectImages");
        }
    }
}
