using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bshop.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Onaylandi",
                table: "Randevular",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 1,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 2,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 3,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 4,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 5,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 6,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 7,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 8,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 9,
                column: "Onaylandi",
                value: false);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 10,
                column: "Onaylandi",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Onaylandi",
                table: "Randevular");
        }
    }
}
