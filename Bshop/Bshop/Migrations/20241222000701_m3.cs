using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bshop.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hizmets",
                columns: new[] { "Id", "Description", "DurationMinutes", "Name", "PhotoUrl", "Price" },
                values: new object[,]
                {
                    { 1, "Profesyonel saç kesimi hizmeti.", 30, "Saç Kesimi", "https://example.com/photos/sac_kesimi.jpg", 100m },
                    { 2, "Derinlemesine cilt bakımı.", 60, "Cilt Bakımı", "https://example.com/photos/cilt_bakimi.jpg", 200m },
                    { 3, "Bakımlı tırnaklar için manikür.", 45, "Manikür", "https://example.com/photos/manikur.jpg", 150m },
                    { 4, "Profesyonel saç boyama hizmeti.", 90, "Saç Boyama", "https://example.com/photos/sac_boyama.jpg", 250m },
                    { 5, "Pürüzsüz cilt için epilasyon hizmeti.", 75, "Epilasyon", "https://example.com/photos/epilasyon.jpg", 180m },
                    { 6, "Rahatlatıcı masaj hizmeti.", 60, "Masaj", "https://example.com/photos/masaj.jpg", 220m },
                    { 7, "Özel tırnak tasarımları.", 50, "Tırnak Tasarımı", "https://example.com/photos/tirnak_tasarimi.jpg", 170m },
                    { 8, "Özel günler için profesyonel makyaj.", 120, "Profesyonel Makyaj", "https://example.com/photos/makyaj.jpg", 300m },
                    { 9, "Doğal ve uzun kaş ve kirpikler.", 40, "Kaş ve Kirpik Uzatma", "https://example.com/photos/kas_kirpik_uzatma.jpg", 130m },
                    { 10, "Cilt yenileyici vücut bakımı hizmeti.", 80, "Vücut Bakımı", "https://example.com/photos/vucut_bakimi.jpg", 210m }
                });

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "ContactNumber", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "0212 555 1234", "İstanbul", "Güzellik Merkezi A" },
                    { 2, "0312 555 5678", "Ankara", "Saç ve Cilt Studio" },
                    { 3, "0232 555 9012", "İzmir", "Elegance Salonu" },
                    { 4, "0228 555 3456", "Bursa", "Premium Güzellik" },
                    { 5, "0242 555 7890", "Antalya", "Moda Saç Salonu" },
                    { 6, "0322 555 2345", "Adana", "Sihirli Eller" },
                    { 7, "0462 555 6789", "Trabzon", "Şıklık Noktası" },
                    { 8, "0342 555 0123", "Gaziantep", "Lüks Güzellik" },
                    { 9, "0352 555 4567", "Kayseri", "Parlak Saç" },
                    { 10, "0332 555 8901", "Konya", "Zarif Cilt Bakımı" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { 1, "john@example.com", "John Doe", "password123", "0500 000 0000", 2 },
                    { 2, "jane@example.com", "Jane Smith", "password123", "0500 000 0001", 2 },
                    { 3, "alice@example.com", "Alice Johnson", "password123", "0500 000 0002", 2 },
                    { 4, "michael@example.com", "Michael Brown", "password123", "0500 000 0003", 2 },
                    { 5, "emily@example.com", "Emily Davis", "password123", "0500 000 0004", 2 },
                    { 6, "david@example.com", "David Wilson", "password123", "0500 000 0005", 2 },
                    { 7, "sarah@example.com", "Sarah Miller", "password123", "0500 000 0006", 2 },
                    { 8, "chris@example.com", "Chris Martin", "password123", "0500 000 0007", 2 },
                    { 9, "lisa@example.com", "Lisa Taylor", "password123", "0500 000 0008", 2 },
                    { 10, "tom@example.com", "Tom Clark", "password123", "0500 000 0009", 2 }
                });

            migrationBuilder.InsertData(
                table: "Calisans",
                columns: new[] { "Id", "ExperienceYears", "FullName", "SalonId" },
                values: new object[,]
                {
                    { 1, 5, "Mehmet Yılmaz", 1 },
                    { 2, 3, "Ayşe Demir", 2 },
                    { 3, 4, "Fatma Kaya", 3 },
                    { 4, 6, "Ali Can", 4 },
                    { 5, 2, "Elif Öz", 5 },
                    { 6, 7, "Burak Şahin", 6 },
                    { 7, 4, "Deniz Arslan", 7 },
                    { 8, 5, "Zeynep Aydın", 8 },
                    { 9, 3, "Okan Güneş", 9 },
                    { 10, 4, "Selin Toprak", 10 }
                });

            migrationBuilder.InsertData(
                table: "CalisanHizmets",
                columns: new[] { "Id", "CalisanId", "HizmetId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 5, 3, 1 },
                    { 6, 3, 3 },
                    { 7, 4, 4 },
                    { 8, 5, 7 },
                    { 9, 6, 5 },
                    { 10, 7, 6 },
                    { 11, 8, 2 },
                    { 12, 9, 4 },
                    { 13, 10, 8 }
                });

            migrationBuilder.InsertData(
                table: "CalismaSaatis",
                columns: new[] { "Id", "BaslangicSaati", "BitisSaati", "CalisanId", "Gun" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1, 1 },
                    { 2, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1, 2 },
                    { 3, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1, 3 },
                    { 4, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1, 4 },
                    { 5, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 2, 1 },
                    { 6, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 2, 3 },
                    { 7, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 2, 5 },
                    { 8, new TimeSpan(0, 8, 30, 0, 0), new TimeSpan(0, 16, 30, 0, 0), 3, 2 },
                    { 9, new TimeSpan(0, 8, 30, 0, 0), new TimeSpan(0, 16, 30, 0, 0), 3, 4 },
                    { 10, new TimeSpan(0, 8, 30, 0, 0), new TimeSpan(0, 16, 30, 0, 0), 3, 6 },
                    { 11, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 4, 1 },
                    { 12, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 4, 3 },
                    { 13, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 4, 5 },
                    { 14, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 5, 2 },
                    { 15, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 5, 4 },
                    { 16, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 6, 1 },
                    { 17, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 6, 3 },
                    { 18, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 6, 5 },
                    { 19, new TimeSpan(0, 9, 30, 0, 0), new TimeSpan(0, 17, 30, 0, 0), 7, 2 },
                    { 20, new TimeSpan(0, 9, 30, 0, 0), new TimeSpan(0, 17, 30, 0, 0), 7, 4 },
                    { 21, new TimeSpan(0, 9, 30, 0, 0), new TimeSpan(0, 17, 30, 0, 0), 7, 6 },
                    { 22, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 8, 1 },
                    { 23, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 8, 3 },
                    { 24, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 8, 5 },
                    { 25, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 9, 2 },
                    { 26, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 9, 4 },
                    { 27, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 9, 6 },
                    { 28, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 10, 2 },
                    { 29, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 10, 4 },
                    { 30, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 10, 6 }
                });

            migrationBuilder.InsertData(
                table: "Randevular",
                columns: new[] { "Id", "CalisanHizmetId", "RandevuSaati", "SalonId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 3, new DateTime(2024, 1, 11, 11, 30, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, 5, new DateTime(2024, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, 7, new DateTime(2024, 1, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 5, 9, new DateTime(2024, 1, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 6, 10, new DateTime(2024, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { 7, 6, new DateTime(2024, 1, 16, 10, 30, 0, 0, DateTimeKind.Unspecified), 7, 7 },
                    { 8, 2, new DateTime(2024, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, 8 },
                    { 9, 4, new DateTime(2024, 1, 18, 9, 30, 0, 0, DateTimeKind.Unspecified), 9, 9 },
                    { 10, 8, new DateTime(2024, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 10, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CalismaSaatis",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 10);

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
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CalisanHizmets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 8);

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Calisans",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hizmets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
