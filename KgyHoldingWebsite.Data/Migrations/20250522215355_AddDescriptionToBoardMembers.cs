using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KgyHoldingWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToBoardMembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BoardMembers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "BoardMembers");
        }
    }
}
