﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KgyHoldingWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddKeywordsToPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "Pages");
        }
    }
}
