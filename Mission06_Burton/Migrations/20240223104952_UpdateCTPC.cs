using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Burton.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCTPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CopiedToPlex",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopiedToPlex",
                table: "Movies");
        }
    }
}
