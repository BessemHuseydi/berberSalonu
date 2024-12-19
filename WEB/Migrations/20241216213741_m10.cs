using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class m10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HizmetId1",
                table: "Randevular",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonId1",
                table: "Randevular",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Randevular",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "HizmetId1", "SalonId1", "UserId1" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHx9nn0mcVFXSCmOl0Xym+THHzzh+xlDghnJFqHbum0nj0wpLs+En6VT+yR+SfzuTQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIKg6dsdmDgNKveF5HZXw3aUuE+oTFlZEcdW2RburgRUnLq0W2el8jWfayBUUjmxlw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELGOCNKlGsjAGsSyWxq7YMMuHyv7h/YUxwfN+YtmgQTKHa4uLJsKXQv+MnMkePsoNw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIiSy2G1i/Et6VeMF09xX0JSvvZg8eYBMQm9sXGVjc8I0jYRMPVF1RkUAVlPHwlcIA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIm2gBnjymTw50N7M0rL/SPaGgkvyUEIEhAl736iZnGi26KAH2zSffutWcXZ07iynw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHXw+Rb59LMHm6xXOmgQNrf8pdjFbQr5yrHTBq189jGQHGBTc8sslLdeRUXOMse+dg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFoz3o2FY6/Wh3EPZKojKIUnzyTpbGP+WifV7t13JCpOVr31kePXilCkOLOozCJd9A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEALsOGzS0SwtL6p5plPfuR+aK4BIf2o5GoRfZcFPOocT/s5freRWFZt7mqfBKh18dQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHMHWeSrG6gb5W9khnWzqLuEfQqSBlXwHD7feblnLz2BsGLa8PGmxOsnRV08hSwcvw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEzlJVSjxmJr+qa0VxUTicCcmhDZS+2RuClKWNMqt5Es/CC78f5Qqs8O4kbzTl2wgQ==");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_HizmetId1",
                table: "Randevular",
                column: "HizmetId1");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_SalonId1",
                table: "Randevular",
                column: "SalonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_UserId1",
                table: "Randevular",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_Hizmetler_HizmetId1",
                table: "Randevular",
                column: "HizmetId1",
                principalTable: "Hizmetler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_Salonlar_SalonId1",
                table: "Randevular",
                column: "SalonId1",
                principalTable: "Salonlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_Users_UserId1",
                table: "Randevular",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_Hizmetler_HizmetId1",
                table: "Randevular");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_Salonlar_SalonId1",
                table: "Randevular");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_Users_UserId1",
                table: "Randevular");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_HizmetId1",
                table: "Randevular");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_SalonId1",
                table: "Randevular");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_UserId1",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "HizmetId1",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "SalonId1",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Randevular");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE/jmGL7OIM1ybq2TX6A/vKwRBiU4bLzOOpUoXafEFLqXY5SawoKX38g7z73PBCGKA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJUym/M/B47Y03FsOdTgn0Pf/3EokgiZHasNm0u6fBMwVTgT+jG0NtVnphUXoaG8tg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPewvo7m4TH+zTHhhz8GbxJufmXhINvVT2UYvvsuVAVbilMNcEb7EvzyZ9PeIodiuQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC0vEJTWqc590OPcamT0k1pczV79xLhhcJGMx/opv83WhzOiobF0w1nXPsysqOwQbw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGcWYYirA1V3GwP3pY1MNZrDiemY6ENlJJEVIhypDtY/ccgo5BKXcPxiPS3n3ZN/Iw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGA7BeecEKb0ZYWFo+6s4JIMz3PAvhGmvGtirtdiGAsJYgXEdu6N9V7jraIMkSXjXg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFWOpkY6068wxuwGEYLkKlBhb2vRjNVIWBuviQDI2yu+su+Rq0uLe1hy/LLyZgC5vw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDTDLv+bjkgPZK7uQSytVMUcgLAP/80rPNRBdVon5pAZEJdklM8XUDrgtFipHP98cg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKFQcM3BvXE7TUmJKPv/R4ygKCHRoHroOr/3FKL+TvdLFEKuKowac8CzwIIW5pUJfw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGldV7zv242CdBywqIY8VJ/w7IJ8vjLZw4GacE1aAReVS7JHzYmErQy27HK3sjpA8A==");
        }
    }
}
