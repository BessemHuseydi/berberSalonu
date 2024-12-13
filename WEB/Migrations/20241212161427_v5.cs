using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 20, "Sakal Tıraşı", 40m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 15, "Saç Yıkama", 20m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 25, "Sakal Şekillendirme", 60m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 15, "Kaş Şekillendirme", 30m });

            migrationBuilder.InsertData(
                table: "Hizmetler",
                columns: new[] { "Id", "DurationMinutes", "Name", "Price" },
                values: new object[,]
                {
                    { 6, 10, "Bıyık Düzeltme", 20m },
                    { 7, 90, "Saç Boyama", 200m },
                    { 8, 120, "Cilt Bakımı", 150m },
                    { 9, 20, "Yüz Masajı", 80m },
                    { 10, 180, "Damat Tıraşı", 300m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 45, "Manikür", 80m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 60, "Pedikür", 100m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 90, "Saç Boyama", 200m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 120, "Cilt Bakımı", 150m });

            migrationBuilder.InsertData(
                table: "Salonlar",
                columns: new[] { "Id", "ContactNumber", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "02124567890", "İstanbul", "Elite Güzellik Salonu" },
                    { 2, "03124567890", "Ankara", "Lüks Kuaför" },
                    { 3, "02324567890", "İzmir", "Güzellik Merkezi" },
                    { 4, "02424567890", "Antalya", "Bakım ve Spa" },
                    { 5, "02224567890", "Bursa", "Zen Saç Stüdyosu" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Phone" },
                values: new object[,]
                {
                    { 1, "ahmet.yilmaz@gmail.com", "Ahmet Yılmaz", "AQAAAAIAAYagAAAAENVUWZjfUYeAMR0HV7xjsgJBkXsNdMENY9UQ7ilZmOeuGE0IQgGLypH2b9YrvUr4dw==", "05331234567" },
                    { 2, "ayse.demir@gmail.com", "Ayşe Demir", "AQAAAAIAAYagAAAAEHaBTGjYapaSPhvK/CL1a1Xw8F1d4PumhOTCdOfzxGjU80ztS9HzgXfuKHhyqkyMJw==", "05339876543" },
                    { 3, "fatma.celik@gmail.com", "Fatma Çelik", "AQAAAAIAAYagAAAAEKHicDvB8nSPSQwBPCRV0D+qsVvphau981YZdMhmuj4dgzp9oatquoQ02QqemFYgDw==", "05431234567" },
                    { 4, "mehmet.kara@gmail.com", "Mehmet Kara", "AQAAAAIAAYagAAAAEBCDFsvBsC+8GZBvdKEmDtkbJpW1pBaeenuYNTzwihXYi1v3bYU+I+aY1kWHD5u5DQ==", "05439876543" },
                    { 5, "ali.can@gmail.com", "Ali Can", "AQAAAAIAAYagAAAAEGv9cz4cHQfNvRidganxzPMlQ2H/wAD20TbwAqaKoamF1jvtTUyFB9XJzU6HDFpZ6w==", "05551234567" }
                });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[,]
                {
                    { 1, 5, "Zeynep Aydın", "Kuaför", 1 },
                    { 2, 3, "Hülya Akın", "Manikürist", 2 },
                    { 3, 4, "Burak Şen", "Pedikürist", 3 },
                    { 4, 6, "Elif Güneş", "Cilt Bakım Uzmanı", 4 },
                    { 5, 7, "Selim Kaya", "Saç Stilisti", 5 }
                });

            migrationBuilder.InsertData(
                table: "Randevular",
                columns: new[] { "Id", "AppointmentTime", "Price", "SalonId", "Service", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 50m, 1, "Saç Kesimi", 1 },
                    { 2, new DateTime(2024, 12, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 80m, 2, "Manikür", 2 },
                    { 3, new DateTime(2024, 12, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 100m, 3, "Pedikür", 3 },
                    { 4, new DateTime(2024, 12, 16, 11, 0, 0, 0, DateTimeKind.Unspecified), 150m, 4, "Cilt Bakımı", 4 },
                    { 5, new DateTime(2024, 12, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), 200m, 5, "Saç Boyama", 5 }
                });

            migrationBuilder.InsertData(
                table: "CalismaSaatleri",
                columns: new[] { "Id", "CalisanId", "DayOfWeek", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, "Pazartesi", new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 2, 2, "Salı", new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 3, 3, "Çarşamba", new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 4, 4, "Perşembe", new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 9, 30, 0, 0) },
                    { 5, 5, "Cuma", new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) }
                });
        }
    }
}
