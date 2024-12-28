using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bshop.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Hizmets");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Hizmets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Hizmets");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Hizmets",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
