using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 6, "Ali Yılmaz", "Berber", 1 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Position", "SalonId" },
                values: new object[] { "Selin Arslan", "Saç Stilisti", 1 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 3, "Ayşe Demir", "Makyaj Uzmanı", 1 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Position", "SalonId" },
                values: new object[] { "Mehmet Kaya", "Masaj Terapisti", 1 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 3, "Hülya Akın", "Manikürist", 2 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 5, "Fatma Çelik", "Pedikürist", 2 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 8, "Ahmet Şen", "Berber", 2 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 6, "Burcu Arslan", "Cilt Bakım Uzmanı", 2 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 4, "Burak Şen", "Pedikürist", 3 });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[,]
                {
                    { 11, 7, "Selim Kaya", "Saç Stilisti", 3 },
                    { 12, 2, "Buse Güneş", "Kuaför", 3 },
                    { 13, 6, "Kemal Demir", "Berber", 3 },
                    { 14, 3, "Aycan Yıldız", "Makyaj Uzmanı", 3 },
                    { 15, 6, "Elif Güneş", "Cilt Bakım Uzmanı", 4 },
                    { 16, 8, "Hasan Çelik", "Masaj Terapisti", 4 },
                    { 17, 5, "Fatih Arslan", "Berber", 4 },
                    { 18, 4, "Burcu Kaya", "Kuaför", 4 },
                    { 19, 3, "Zehra Şahin", "Makyaj Uzmanı", 4 },
                    { 20, 7, "Selim Kaya", "Saç Stilisti", 5 },
                    { 21, 3, "Merve Şen", "Manikürist", 5 },
                    { 22, 8, "Ahmet Çelik", "Berber", 5 },
                    { 23, 5, "Fatma Yıldız", "Pedikürist", 5 },
                    { 24, 8, "Kemal Yılmaz", "Berber", 6 },
                    { 25, 6, "Zehra Akın", "Kuaför", 6 },
                    { 26, 4, "Aycan Arslan", "Makyaj Uzmanı", 6 },
                    { 27, 7, "Emre Şen", "Masaj Terapisti", 6 },
                    { 28, 4, "Merve Şen", "Makyaj Uzmanı", 7 },
                    { 29, 5, "Fatih Çelik", "Masaj Terapisti", 7 },
                    { 30, 6, "Büşra Arslan", "Kuaför", 7 },
                    { 31, 9, "Hasan Kaya", "Berber", 7 },
                    { 32, 5, "Fatih Çelik", "Masaj Terapisti", 8 },
                    { 33, 4, "Burcu Yıldız", "Kuaför", 8 },
                    { 34, 7, "Emre Kaya", "Berber", 8 },
                    { 35, 3, "Selin Şen", "Makyaj Uzmanı", 8 },
                    { 36, 10, "Ahmet Arslan", "Berber", 9 },
                    { 37, 5, "Zehra Demir", "Kuaför", 9 },
                    { 38, 7, "Kemal Şahin", "Masaj Terapisti", 9 },
                    { 39, 4, "Fatma Çelik", "Makyaj Uzmanı", 9 },
                    { 40, 2, "Ayşe Can", "Manikürist", 10 },
                    { 41, 7, "Selim Kaya", "Saç Stilisti", 10 },
                    { 42, 8, "Hasan Şen", "Berber", 10 },
                    { 43, 3, "Büşra Çelik", "Makyaj Uzmanı", 10 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJodGf5Kkttd8dfw3bmNPQT5xb1TRchUrf1UCyfK+2usxD5PxiZ3gTwDiLEh021dHg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN7PFUqRrtFwoG4GQjRvjmfvulDgDMzyXOwjXXIoZEgYu9UoArPldvsuRvxBTLM9Pw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGMf2oRO5mWuDUrDW3KX2petP9Bnkt2Oeqnf0OWaAygKvTnWirOkPVNWLD05j3yV2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELUrIItCV3mzOjw9suxrGlniTTjvjwQ9OsYzWvBjB/6Rhdy6YtoRfrC7XYRaeFdRmw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMMRyA+AMBxJvfb9B4lQhUdq8E675xj7dqQ1bOppuU8it+5tFScBppdKf4eyV6BjyQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEItGbVldXz4GQjmKA5aQlscHJlngXeWW7GoKBHijB57t2/fY9UsVpRTepZWNJNyCew==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL8gB76+wNd5/qtzDuo5WUsRIiX/85idT+4+Vxq/W4LW8SYMcL2HYZ8xddJbhX/xCQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOyFKGBTMoOWHgG+E3iePDmCwg+AyOuZ9YLwof3OGBXkajvSOiynWeMuPJF1aLwVNg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDmT9f5zn90HoXsUBXvZAQzZwImB28OJexjyKSGwH5xBSTXuPBD0oJhGwfyu0OQ0xA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEF/AM7wJ8VQSriQ02xuXNrVj59RWXAOvwkkys8sWJx5BGyPFbs7NSOCPhx1SjQ2jUw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 3, "Hülya Akın", "Manikürist", 2 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Position", "SalonId" },
                values: new object[] { "Burak Şen", "Pedikürist", 3 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 6, "Elif Güneş", "Cilt Bakım Uzmanı", 4 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Position", "SalonId" },
                values: new object[] { "Selim Kaya", "Saç Stilisti", 5 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 8, "Kemal Yılmaz", "Berber", 6 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 4, "Merve Şen", "Makyaj Uzmanı", 7 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 5, "Fatih Çelik", "Masaj Terapisti", 8 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 10, "Ahmet Arslan", "Berber", 9 });

            migrationBuilder.UpdateData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExperienceYears", "Name", "Position", "SalonId" },
                values: new object[] { 2, "Ayşe Can", "Manikürist", 10 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFqGGpfegR94TQedcCZzTtvLQOjMcVspBuzgU4NCm4enozKg+2mAU0C3SH8EP4RYKw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKZQpOfAJhJ7Bmz5zhjfsOGGZZ2mv6KPbxyNHw1MUlC/ARSeskmhH8Ur5d/nQSLYhg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGKaUlA+mzMNhWxyIQ/bCcJ0ivmPP2cAlJCuAIwQx6kVn9EWiO927pH9WVk4/EKtuQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBs1F4bM95t7yIgLyuiMpPE9zMiZvuAwmJheDoMFnNU1zK9poaK2z9jh2vjvOnKTwQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJBgrve/0QveP3ewYEpu1udBwpc7ftzdqyHyIp8oM0WrzDt5xjrWrxJV5o7a9GBfXg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFLw3Ewno6KpR4M+BIvWJLu1cv+pA2v6N8zJcZU5YeoTf6xPPYO2yBRommQeNw+0hA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBb2oB9SN+3B6i5ZMVXmZ8DdcVK+gQO5uH2yB6lN8U17VgcZgarOCm+RKeLAu0X2/g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBa7jfpcLvDJOyblx4sfl/czHa7P3/w47TOtx8+mCawIJd5K4ERA6Jl3Ytpfv+OeaA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN36bMEVhhgFvrJLTBBY6bECWpd+Ex1K3viG2sW479YdlP8mbtKy1oHg9LLv16C6dQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAua1SLXSr5H4a8r99hKsImpYoklhWrpsF/rUpFOrYjTNXNh4JX8uBI6D8LBELKAbA==");
        }
    }
}
