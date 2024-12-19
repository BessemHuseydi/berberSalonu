using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class m13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    HizmetId = table.Column<int>(type: "int", nullable: false),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rrs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rrs_Hizmetler_HizmetId",
                        column: x => x.HizmetId,
                        principalTable: "Hizmetler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rrs_Salonlar_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rrs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEElS4fvnLnY9lXMEsKIZF8eysVhhizbf0xIUJRQnn0xof+v74Z9zFGNfnB6nJqe9xA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKRmgzz202iZZt10FkxdQIrtBOBFRx97FSkWu0U4/RMeEQ1V6QDVBuXujj1/wk3wmw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMquzKeLYjJrzN6ob8NDTXC+EcCnl/D4B6q8ivm4pabsTdtzY11lqS2j7SMrxEmEQw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENVfkHzdyAJrkJT1/XkQj4qZhg6IjKOVcIEbLHe50DSLpnf3ahX8B7X5V0Ci/ZXHWA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC1EpW9tgbyb82H3+4zqE4Oxc/BFsGYqVzSKgG0svuyAnFt1xCQ9gxw4DTLupYFETA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJUreBAiN5fKg1nJwmbmMsRbuNwOV0mSAVI8AqMJFR8kPd11rLujlkmbvjbN3ma1cQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFwHEpHF/Gh7Vj5tJPGfVeOUcMyVDKbE12mfKrZkS0KQ+duaTL71nzUntyqQJd6LnQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIxgteuVk4B+NVFBdvIhy7trMXxCIlNkYQLwrCkD3MWFMqesJgvzTfC/YjJDhsK6CA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEWmAf+NGvpo88VULyauNhttBXYCcNkNWx9YPtbSYIgWm6r5+6kft/tQrmgk4hmODA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO6PMaw+cJ0/QbSNC13Or98YLB4z7OtOPIgPeOUvrC4PYb/w4pcIlA8tBU35UxD5dQ==");

            migrationBuilder.CreateIndex(
                name: "IX_Rrs_HizmetId",
                table: "Rrs",
                column: "HizmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Rrs_SalonId",
                table: "Rrs",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Rrs_UserId",
                table: "Rrs",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rrs");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMDN+WF+b8X8KNaPNs/XR4slw6Zh5fszTJzngEuqqMxwEGMsneTOybS+XBP5wklJnA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENDCa0DdE+/krfKEyYncQyPa9vLmgBTxFIj757yR+EXjqXWjd/oKDlP4Rmp9DPzK9Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM9GnPpTccYWZwdoTbEx7HgLwqRXgb3XLalaX14TrS4kRL8JmISHIEfLIn6M+dVA1w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGoETA0aEjWa8OupM6A28oFy5l22i8YiIRh5tvY5H121ybcVFtZP8ezKn+7L6oBpOA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELy0q1hHYCJMKcghD33wywxkoI9iXeyiYnUumPuwGXqiokPojGHcloOtLeQUorn4/A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFj6XxSlCnQxSpCQ1TduJAiTUXs4RfyMEawHNJ2gIyLddLJjjlUeiV9ifDtnt9xXsw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKEJFKo1UXeQByP+isw9yW2PGk9ZGVnzNKPsAI0EKquf/lvx6ybEKihrYjUD9LB2Pw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8ZEj4o5An2K8cFU5SyZnSug3Zr2U4N7jtR1nWikz6X3HG9KTjEwm6pFj3USJzJXA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB50kd+NbzqRHWnRWx781DIf8202EwZ7jWgJGRIQJuoqnW5VX0fVXG8olkX0TsK3gg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ2O6zOj5RN49rpRC1EokOra5gqJDKgMmNXQTMyNXacFZTk4YAg2giYvJWWLTSzeJw==");
        }
    }
}
