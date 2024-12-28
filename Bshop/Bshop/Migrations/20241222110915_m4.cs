using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bshop.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhotoUrl",
                value: "~/img/hizmetler/sakalbakimi.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "https://example.com/photos/sac_kesimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "https://example.com/photos/cilt_bakimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "https://example.com/photos/manikur.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoUrl",
                value: "https://example.com/photos/sac_boyama.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoUrl",
                value: "https://example.com/photos/epilasyon.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoUrl",
                value: "https://example.com/photos/masaj.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoUrl",
                value: "https://example.com/photos/tirnak_tasarimi.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoUrl",
                value: "https://example.com/photos/makyaj.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhotoUrl",
                value: "https://example.com/photos/kas_kirpik_uzatma.jpg");

            migrationBuilder.UpdateData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhotoUrl",
                value: "https://example.com/photos/vucut_bakimi.jpg");
        }
    }
}
