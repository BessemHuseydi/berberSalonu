using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hizmetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calisanlar_Salonlar_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevular_Salonlar_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevular_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalismaSaatleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanId = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaSaatleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalismaSaatleri_Calisanlar_CalisanId",
                        column: x => x.CalisanId,
                        principalTable: "Calisanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "ahmet.yilmaz@gmail.com", "Ahmet Yılmaz", "05331234567" },
                    { 2, "ayse.demir@gmail.com", "Ayşe Demir", "05339876543" },
                    { 3, "fatma.celik@gmail.com", "Fatma Çelik", "05431234567" },
                    { 4, "mehmet.kara@gmail.com", "Mehmet Kara", "05439876543" },
                    { 5, "ali.can@gmail.com", "Ali Can", "05551234567" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_SalonId",
                table: "Calisanlar",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_CalismaSaatleri_CalisanId",
                table: "CalismaSaatleri",
                column: "CalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_SalonId",
                table: "Randevular",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_UserId",
                table: "Randevular",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalismaSaatleri");

            migrationBuilder.DropTable(
                name: "Hizmetler");

            migrationBuilder.DropTable(
                name: "Randevular");

            migrationBuilder.DropTable(
                name: "Calisanlar");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Salonlar");
        }
    }
}
