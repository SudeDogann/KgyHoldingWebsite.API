using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KgyHoldingWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSubjectToContactMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "ContactMessages");
        }
    }
}
