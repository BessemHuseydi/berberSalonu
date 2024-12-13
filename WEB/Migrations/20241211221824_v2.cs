using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
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
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hizmetler",
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

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPBrFx5KJPd+sfif5czTeRORH7YttTr7tJMT3xmhcU3AZG6qLLI7eRFtfV6vSzsRsg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPz5tTMcqnbSftTBwyLrHBcKY2TFJFU+82cjAv0x3pX9HDD1pDPleC+aPH23dHCF+g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL+aH7s5kPKpH5eZRQxqbG0Kyqohar72Y2+O3jsUTwSJOH76xd5RO/dZNorEfXtyxQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHbuA/Gd2U8BUnljh4kN2ijm12gCnlNVU4BiiZLQsfW1W+b1koJJZKuVymHjsVVH/g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFqi3kwp1ig6RqQPk7kALctGGtNE6tDbQaNwEZXiEi+m+fclntP8tzBTxZlhJylfCw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Hizmetler",
                columns: new[] { "Id", "DurationMinutes", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 30, "Saç Kesimi", 50m },
                    { 2, 45, "Manikür", 80m },
                    { 3, 60, "Pedikür", 100m },
                    { 4, 90, "Saç Boyama", 200m },
                    { 5, 120, "Cilt Bakımı", 150m }
                });

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
