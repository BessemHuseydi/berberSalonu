using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 25, "Sakal Kesimi", 40m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 60, "Masaj", 250m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 15, "Saç Yıkama", 20m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 30, "Yüz Temizleme", 100m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 20, "Bıyık Şekillendirme", 30m });

            migrationBuilder.InsertData(
                table: "Salonlar",
                columns: new[] { "Id", "ContactNumber", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "02124567890", "İstanbul", "Elite Güzellik Salonu" },
                    { 2, "03124567890", "Ankara", "Lüks Kuaför" },
                    { 3, "02324567890", "İzmir", "Güzellik Merkezi" },
                    { 4, "02424567890", "Antalya", "Bakım ve Spa" },
                    { 5, "02224567890", "Bursa", "Zen Saç Stüdyosu" },
                    { 6, "03224567890", "Adana", "Royal Saç Merkezi" },
                    { 7, "03424567890", "Gaziantep", "Luxury Hair" },
                    { 8, "03524567890", "Kayseri", "Dream Spa" },
                    { 9, "02224567891", "Eskişehir", "Modern Güzellik" },
                    { 10, "03324567890", "Konya", "Prestij Bakım Merkezi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "Phone" },
                values: new object[,]
                {
                    { 1, "ahmet.yilmaz@gmail.com", "Ahmet Yılmaz", "AQAAAAIAAYagAAAAEE+xkJbhBjWwdMfHeAsdWoOGCLoSQzmWmkzgMkTHjshNPkqWauzwxozdH7ugHtKWTw==", "05331234567" },
                    { 2, "ayse.demir@gmail.com", "Ayşe Demir", "AQAAAAIAAYagAAAAEJ3TYj8Hl5lK8MN0lsP9Zvqx/14nZLxtI2r8HZzRewidJ/zu8CNPjG3fbjFjkZNTcA==", "05339876543" },
                    { 3, "fatma.celik@gmail.com", "Fatma Çelik", "AQAAAAIAAYagAAAAECKffer5PM5l2KKjOMoNYrLQHa1bqW9G2S0FDwRTUjecxI7ayAvaXvZ3/IWGLo67Dw==", "05431234567" },
                    { 4, "mehmet.kara@gmail.com", "Mehmet Kara", "AQAAAAIAAYagAAAAEDo5Q0Dsl6JpcE6WJHd9wmSgAj97gygchwNRxQw7RA3rhKmheUyTOnhYjcfK9KOynw==", "05439876543" },
                    { 5, "ali.can@gmail.com", "Ali Can", "AQAAAAIAAYagAAAAEEKVeIn/wPJCFbgRPKKKU2QY02XBLMe0B12CivhihrvkHk6vIDG8a8nQ7t0PFQKG/A==", "05551234567" },
                    { 6, "merve.sen@gmail.com", "Merve Şen", "AQAAAAIAAYagAAAAEAw1R59egwEj196SW+hMYWDVSQ3iyh7227Nut1iVFaX70fmUT0v+SXwOJS8Ols7v/g==", "05631234567" },
                    { 7, "burak.arslan@gmail.com", "Burak Arslan", "AQAAAAIAAYagAAAAEKq7mcHpz4RALIrZf65d31CUSCXz9rc6oM7UTDIV5drMe4ZrxPw8k9ybEHRRdpXflA==", "05471234567" },
                    { 8, "emre.yildiz@gmail.com", "Emre Yıldız", "AQAAAAIAAYagAAAAEPe9I9SfjiHWJ6NgzuzmwV3s+EJyYsbZim7x76NXSlfo2D3FJFZA0Q9ZwY67T23gkg==", "05381234567" },
                    { 9, "elif.gul@gmail.com", "Elif Gül", "AQAAAAIAAYagAAAAEHRCrfeCEFmPHxTAYe3LBDm3FJ/s9M9XoDNqLaSU4zX7h2tiM03PPhUWomfmDmAyjA==", "05569876543" },
                    { 10, "huseyin.demir@gmail.com", "Hüseyin Demir", "AQAAAAIAAYagAAAAEC2lhHU67lB55slDAZBwCT3uWstY5K0kWDeDa4HKfinY0Q5o/DjExeULoRuz/cMNQQ==", "05351239876" }
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
                    { 5, 7, "Selim Kaya", "Saç Stilisti", 5 },
                    { 6, 8, "Kemal Yılmaz", "Berber", 6 },
                    { 7, 4, "Merve Şen", "Makyaj Uzmanı", 7 },
                    { 8, 5, "Fatih Çelik", "Masaj Terapisti", 8 },
                    { 9, 10, "Ahmet Arslan", "Berber", 9 },
                    { 10, 2, "Ayşe Can", "Manikürist", 10 }
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
                    { 5, new DateTime(2024, 12, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), 200m, 5, "Saç Boyama", 5 },
                    { 6, new DateTime(2024, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 40m, 6, "Sakal Kesimi", 6 },
                    { 7, new DateTime(2024, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 250m, 7, "Masaj", 7 },
                    { 8, new DateTime(2024, 12, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 100m, 8, "Yüz Temizleme", 8 },
                    { 9, new DateTime(2024, 12, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 50m, 9, "Saç Kesimi", 9 },
                    { 10, new DateTime(2024, 12, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 80m, 10, "Manikür", 10 }
                });

            migrationBuilder.InsertData(
                table: "CalismaSaatleri",
                columns: new[] { "Id", "CalisanId", "DayOfWeek", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, "Pazartesi", new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 2, 1, "Salı", new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 3, 1, "Çarşamba", new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 4, 1, "Perşembe", new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 5, 1, "Cuma", new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 6, 1, "Cumartesi", new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 7, 2, "Pazartesi", new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 8, 2, "Salı", new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 9, 2, "Çarşamba", new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 10, 2, "Perşembe", new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 11, 2, "Cuma", new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 12, 2, "Cumartesi", new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 10, 30, 0, 0) },
                    { 13, 3, "Pazartesi", new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 14, 3, "Salı", new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 15, 3, "Çarşamba", new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 16, 3, "Perşembe", new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 17, 3, "Cuma", new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 18, 3, "Cumartesi", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 10);

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
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CalismaSaatleri",
                keyColumn: "Id",
                keyValue: 18);

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
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Salonlar",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 10, "Bıyık Düzeltme", 20m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 90, "Saç Boyama", 200m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 120, "Cilt Bakımı", 150m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 20, "Yüz Masajı", 80m });

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DurationMinutes", "Name", "Price" },
                values: new object[] { 180, "Damat Tıraşı", 300m });
        }
    }
}
