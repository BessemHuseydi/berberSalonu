using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENVUWZjfUYeAMR0HV7xjsgJBkXsNdMENY9UQ7ilZmOeuGE0IQgGLypH2b9YrvUr4dw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHaBTGjYapaSPhvK/CL1a1Xw8F1d4PumhOTCdOfzxGjU80ztS9HzgXfuKHhyqkyMJw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKHicDvB8nSPSQwBPCRV0D+qsVvphau981YZdMhmuj4dgzp9oatquoQ02QqemFYgDw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBCDFsvBsC+8GZBvdKEmDtkbJpW1pBaeenuYNTzwihXYi1v3bYU+I+aY1kWHD5u5DQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGv9cz4cHQfNvRidganxzPMlQ2H/wAD20TbwAqaKoamF1jvtTUyFB9XJzU6HDFpZ6w==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENKKU6y0egqpi6QQ0h8OCCC3rRY5xOA4OEhUjACnQgzYHEJfFUMsQk2z3sklOyn/nQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJj0TfnhyKOws8v4VGLMZDI8Py1LoRqdvfsyS/xlkXT/Gh23m0zL6vVaDrzl8RnWwQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMX7HcCXOEzWonBgmtmn6WMoefHD9C/fHz83ZHe4kN1voyJ0iiz6xNCKjTIcoKlI5A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIJQHLF7lcNj+suHDVW5etV2Dq9mvVvlH4943yCgssMMDv1yLAYIzTT05MIwSuPZTA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFM2F8ilH5X8OC8rZTxzokNc5W83fUo+XsgeNoh+zfPwfS+QLL/XVvafOg5VzfBaUA==");
        }
    }
}
