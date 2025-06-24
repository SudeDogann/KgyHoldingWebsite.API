using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KgyHoldingWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSubtitleToSector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Sectors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Sectors");
        }
    }
}
