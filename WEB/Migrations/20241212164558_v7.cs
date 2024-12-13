using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Hizmetler",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hizmetler",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhotoPath",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Hizmetler");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE+xkJbhBjWwdMfHeAsdWoOGCLoSQzmWmkzgMkTHjshNPkqWauzwxozdH7ugHtKWTw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ3TYj8Hl5lK8MN0lsP9Zvqx/14nZLxtI2r8HZzRewidJ/zu8CNPjG3fbjFjkZNTcA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECKffer5PM5l2KKjOMoNYrLQHa1bqW9G2S0FDwRTUjecxI7ayAvaXvZ3/IWGLo67Dw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDo5Q0Dsl6JpcE6WJHd9wmSgAj97gygchwNRxQw7RA3rhKmheUyTOnhYjcfK9KOynw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEKVeIn/wPJCFbgRPKKKU2QY02XBLMe0B12CivhihrvkHk6vIDG8a8nQ7t0PFQKG/A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAw1R59egwEj196SW+hMYWDVSQ3iyh7227Nut1iVFaX70fmUT0v+SXwOJS8Ols7v/g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKq7mcHpz4RALIrZf65d31CUSCXz9rc6oM7UTDIV5drMe4ZrxPw8k9ybEHRRdpXflA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPe9I9SfjiHWJ6NgzuzmwV3s+EJyYsbZim7x76NXSlfo2D3FJFZA0Q9ZwY67T23gkg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHRCrfeCEFmPHxTAYe3LBDm3FJ/s9M9XoDNqLaSU4zX7h2tiM03PPhUWomfmDmAyjA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC2lhHU67lB55slDAZBwCT3uWstY5K0kWDeDa4HKfinY0Q5o/DjExeULoRuz/cMNQQ==");
        }
    }
}
